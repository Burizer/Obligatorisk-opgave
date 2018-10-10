using System;

namespace TCPServerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server1 = new Server();
            server1.Start();

            Console.ReadLine();
        }
    }
}
