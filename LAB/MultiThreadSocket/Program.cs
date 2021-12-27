using System;
using System.Net.Sockets;

namespace MultiThreadSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().StartConnection();
        }

        public void StartConnection()
        {
            TcpListener server = new TcpListener(8888);
            TcpClient client = default(TcpClient);

            int count = 0;

            server.Start();
            Console.WriteLine("Server Starting...");

            count = 0;
            while (true)
            {
                count += 1;
                client = server.AcceptTcpClient();
                Console.WriteLine("==> Client No: " + Convert.ToString(count) + "joined");
                HandleClient handleClient = new HandleClient();
                handleClient.startClient(client, Convert.ToString(count));
            }
            client.Close();
            server.Stop();
            Console.WriteLine("Exited");
            Console.ReadLine();
        }
    }
}
