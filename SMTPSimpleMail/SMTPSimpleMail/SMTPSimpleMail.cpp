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
#define  HOST "192.168.43.166"

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

	string ReiveData()
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
		
		tcp->SendData("HELO stud_07@domain.local\r\n");
		cout << "Reseive: " << endl;
		cout << tcp->ReceiveData() << endl;

		tcp->SendData("MAIL FROM: <stud_08>\r\n");
		cout << "Reseive: " << endl;
		cout << tcp->ReceiveData() << endl;

		tcp->SendData("RCPT TO:<stud_07>\r\n");
		cout << "Reseive: " << endl;
		cout << tcp->ReceiveData() << endl;

		tcp->SendData("DATA\r\n");
		cout << "Reseive: " << endl;
		cout << tcp->ReceiveData() << endl;

		tcp->SendData("SUBJECT: Lesson\r\n");
		tcp->SendData("FROM: Maksim Rvyanin <maks@domain.local>\r\n");
		tcp->SendData("TO: <admin@domain.local>\r\n");
		tcp->SendData("DATE: Fri, 29 Sep 2017 10:33:04\r\n\r\n");


		tcp->SendData("First line\r\nSecond line\r\n.\r\n");
		cout << "Reseive: " << endl;
		cout << tcp->ReceiveData() << endl;

		tcp->SendData("QUIT\r\n");
		cout << "Reseive: " << endl;
		cout << tcp->ReceiveData() << endl;
		tcp->CloseConnection();
		system("pause");
	}
	catch (string error)
	{
		cout << error;
		tcp->CloseConnection();
	}
}