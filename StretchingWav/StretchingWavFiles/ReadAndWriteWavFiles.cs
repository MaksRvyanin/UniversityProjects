using System;
using  System.IO;

namespace KursRvyanin
{
    class ReadAndWriteWavFiles
    {//The type of data a RIFF file contains is indicated by the file extension
        private const int RiffHeader = 0x46464952;
        private const int WaveHeader = 0x45564157;
        private const int FmtHeader = 0x20746D66;
        private const int DataHeader = 0x61746164;

        public static double[][] Read(string fileName, out int sampFreq)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    if (br.ReadInt32() != RiffHeader)
                    {
                        throw new Exception("It is not a WAV file");
                    }
                    br.ReadInt32();
                    if (br.ReadInt32() != WaveHeader)
                    {
                        throw new Exception("It is not a WAV file");
                    }

                    while (br.ReadInt32() != FmtHeader)
                    {
                        br.BaseStream.Seek(br.ReadInt32() + 1 >> 1 << 1, SeekOrigin.Current);
                    }

                    int numChannels;
                    {
                        byte[] chunk = new byte[br.ReadInt32()];
                        br.Read(chunk, 0, chunk.Length);
                        ReadFmtChunk(chunk, out numChannels, out sampFreq);
                        if ((chunk.Length & 1) > 0) br.ReadByte();
                    }

                    while (br.ReadInt32() != DataHeader)
                    {
                        br.BaseStream.Seek(br.ReadInt32() + 1 >> 1 << 1, SeekOrigin.Current);
                    }

                    {
                        byte[] chunk = new byte[br.ReadInt32()];
                        br.Read(chunk, 0, chunk.Length);
                        return ReadDataChunk(chunk, numChannels);
                    }
                }
            }
        }

        public static double[] ReadMono(string fileName, out int sampFreq)
        {
            return Read(fileName, out sampFreq)[0];
        }

        public static void Write(string fileName, double[][] data, int sampFreq)
        {
            var numChannels = data.Length;
            var pcmLength = data[0].Length;
            var dataChunkSize = 2 * numChannels * pcmLength;
            var riffChunkSize = dataChunkSize + 36;
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(RiffHeader);
                    bw.Write(riffChunkSize);
                    bw.Write(WaveHeader);
                    bw.Write(FmtHeader);
                    bw.Write(16);
                    bw.Write((short)1);
                    bw.Write((short)numChannels);
                    bw.Write(sampFreq);
                    bw.Write(2 * numChannels * sampFreq);
                    bw.Write((short)(2 * numChannels));
                    bw.Write((short)16);
                    bw.Write(DataHeader);
                    bw.Write(dataChunkSize);
                    for (var t = 0; t < pcmLength; t++)
                    {
                        for (int ch = 0; ch < numChannels; ch++)
                        {
                            int s = (int)Math.Floor(32768 * data[ch][t]);
                            if (s < short.MinValue)
                            {
                                s = short.MinValue;
                            }
                            else if (s > short.MaxValue)
                            {
                                s = short.MaxValue;
                            }
                            bw.Write((short)s);
                        }
                    }
                    
                }
            }
        }

        public static void Write(string fileName, double[] data, int sampFreq)
        {
            Write(fileName, new double[][] { data }, sampFreq);
        }

        private static void ReadFmtChunk(byte[] chunk, out int numChannels, out int sampFreq)
        {
            using (MemoryStream ms = new MemoryStream(chunk))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    int formatId = br.ReadInt16();
                    if (formatId != 1)
                    {
                        throw new Exception("Unsupported format");
                    }
                    numChannels = br.ReadInt16();
                    sampFreq = br.ReadInt32();
                    br.ReadInt32();
                    br.ReadInt16();
                    int quantBit = br.ReadInt16();
                    if (quantBit != 16)
                    {
                        throw new Exception("Number of quantization bits not supported");
                    }
                }
            }
            
        }

        private static double[][] ReadDataChunk(byte[] chunk, int numChannels)
        {
            int pcmLength = chunk.Length / (2 * numChannels);
            double[][] data = new double[numChannels][];
            for (int ch = 0; ch < numChannels; ch++)
            {
                data[ch] = new double[pcmLength];
            }
            using (MemoryStream ms = new MemoryStream(chunk))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    for (int t = 0; t < pcmLength; t++)
                    {
                        for (int ch = 0; ch < numChannels; ch++)
                        {
                            data[ch][t] = br.ReadInt16() / 32768.0;
                        }
                    }
                }
            }
            return data;
        }
    }
}
