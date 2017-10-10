// SMTPSimpleMail.cpp : Defines the entry point for the console application.
// Клиент отправляет почтовое сообщение по протоколу SMTP
// Используется AUTH LOGIN авторизация

#include "stdafx.h"
#define _WINSOCK_DEPRECATED_NO_WARNINGS

#include "WinSock2.h"
#include <iostream>
#include <string>
#pragma comment(lib, "Ws2_32.lib")

#define  PORT 25
#define  HOST "10.7.12.31"

using namespace std;


class TCP
{
	SOCKET s;
	WSAData wsaData;

public:
	void Startup()
	{
		if (WSAStartup(MAKEWORD(1, 1), &wsaData) != 0)
		{
			throw string("Initialization failed");
		}
	}

	void InitSocket()
	{
		s = socket(
			AF_INET,
			SOCK_STREAM,
			0);

		if (!s)
		{
			throw string("Error in socket connection");
		}
	}

	void Connect(int port, string host)
	{
		hostent *hinfo = gethostbyname(host.c_str());
		cout << GetLastError();
		sockaddr_in tcpaddr;
		tcpaddr.sin_family = AF_INET;
		tcpaddr.sin_port = htons(port);

		memcpy((char FAR *)&(tcpaddr.sin_addr.s_addr), hinfo->h_addr_list[0], hinfo->h_length);

		if (connect(s, (SOCKADDR*)&tcpaddr, sizeof(tcpaddr)) == -1)
		{
			string error = "Connection error: " + to_string(WSAGetLastError());

			throw error;
		}
	}

	void SendData(string str)
	{
		send(s, str.c_str(), str.length(), 0);
	}

	string ReceiveData()
	{
		char str[1024];

		int countRecieved = recv(s, str, sizeof(str), 0);

		if (countRecieved == SOCKET_ERROR)
		{
			string error = "Receiving data error: " + to_string(WSAGetLastError());

			throw error;
		}
		str[countRecieved] = '\0';

		return string(str);
	}


	bool FindCRLF(string s)
	{
		for (int i = 0; i < s.length() - 4; i++)
		{
			if (s[i] == '\r' && s[i + 1] == '\n' && s[i + 2] == '.' && s[i + 3] == '\r' && s[i + 4] == '\n')
				return true;
		}
		return false;
	}

	bool FindEmptyLine(string s)
	{
		for (int i = 0; i < s.length() - 3; i++)
		{
			if (s[i] == '\r' && s[i + 1] == '\n' && s[i + 3] == '\r' && s[i + 4] == '\n')
				return true;
		}
		return false;
	}

	string ReceiveDataCRLF()
	{
		string temp = "";
		while (true)
		{
			temp += ReceiveData();
			if (FindCRLF(temp))
			{
				break;
			}
		}
		return temp;
	}

	void CloseConnection()
	{
		closesocket(s);
		WSACleanup();
	}
};




int _tmain(int argc, _TCHAR* argv[])
{
	TCP* tcp = new TCP();

	try
	{
		tcp->Startup();
		tcp->InitSocket();
		tcp->Connect(PORT, HOST);

		tcp->SendData("USER stud_07\r\n");
		cout << tcp->ReceiveData();

		tcp->SendData("PASS stud_07\r\n");
		cout << tcp->ReceiveData();

		tcp->SendData("STAT\r\n");
		cout << tcp->ReceiveData();


		tcp->SendData("LIST\r\n");

		cout << endl << endl;
		cout << "List recieved messages: " << endl;
		cout << tcp->ReceiveDataCRLF();

		int index = 1;

		while (index)
		{
			cout << "Input message number to read or 0 to exit\n";

			cin >> index;

			if (!index) break;

			tcp->SendData("RETR " + to_string(index) + "\r\n");

			cout << tcp->ReceiveDataCRLF();
		}


		tcp->SendData("QUIT\r\n");
		cout << tcp->ReceiveData();
		tcp->CloseConnection();
		system("pause");
	}
	catch (string error)
	{
		cout << error;
		tcp->CloseConnection();
	}
}