using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OunceToGramConversion;

namespace TCPServerConversion
{
    class Server
    {
        public Server()
        {

        }
        public void Start()
        {
            TcpListener serverListener1 = new TcpListener(IPAddress.Loopback, 7);
            serverListener1.Start();
            while (true)
            {
                TcpClient tempSocket = serverListener1.AcceptTcpClient();
                Task.Run(() =>
                {
                    DoClient(tempSocket);
                });

            }
        }

        private void DoClient(TcpClient socket1)
        {
            NetworkStream ns = socket1.GetStream();
            using (StreamReader streamReader1 = new StreamReader(ns))
            {
                using (StreamWriter streamWriter1 = new StreamWriter(ns))
                {
                    Thread.Sleep(1000);
                    string str = streamReader1.ReadLine();
                    string[] strSplitter = str.Split(" ");
                    string method = strSplitter[0];
                    string value = strSplitter[1];
                    double number = double.Parse(value);
                    Methods newMethod = new Methods();
                    if (method == "TOGRAM")
                    {
                        System.Console.WriteLine(newMethod.ToGrams(number));
                    }
                    else if (method == "TOOUNCES")
                    {
                        System.Console.WriteLine(newMethod.ToOunces(number));
                    }
                    streamWriter1.WriteLine(str);
                    streamWriter1.Flush();
                }
            }
        }
    }
}
