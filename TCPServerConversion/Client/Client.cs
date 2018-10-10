using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Client
    {
        public Client()
        {

        }
        public void Start()
        {
            using (TcpClient socket1 = new TcpClient(IPAddress.Loopback.ToString(), 7))
            {
                DoClient(socket1);
            }
        }

        private void DoClient(TcpClient socket1)
        {
            NetworkStream ns = socket1.GetStream();
            using (StreamWriter streamWriter1 = new StreamWriter(ns))
            {
                string newStr = Console.ReadLine();
                using (StreamReader streamReader1 = new StreamReader(ns))
                {
                    streamWriter1.WriteLine(newStr);
                    streamWriter1.Flush();
                }
            }
        }
    }
}
