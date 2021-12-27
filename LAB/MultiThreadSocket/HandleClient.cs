using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MultiThreadSocket
{
    class HandleClient
    {
        TcpClient client;
        String clientNo;

        public void startClient(TcpClient inClient, String clientNo)
        {
            this.client = inClient;
            this.clientNo = clientNo;
            Thread thread = new Thread(doChat);
            thread.Start();
        }

        public void doChat()
        {
            int requestCount = 0;
            byte[] byteForm = new byte[65536];
            String dataFormClient = null;
            Byte[] sendByte = null;
            String serverResponse = null;
            String rCount = null;
            requestCount = 0;

            while (true)
            {
                try
                {
                    requestCount += 1;
                    NetworkStream networkStream = client.GetStream();
                    networkStream.Read(byteForm, 0, client.ReceiveBufferSize);
                    dataFormClient = System.Text.Encoding.ASCII.GetString(byteForm);
                    dataFormClient = dataFormClient.Substring(0, dataFormClient.IndexOf("$"));
                    Console.WriteLine(">>>" + "From client " + clientNo + "\n" + dataFormClient);

                    rCount = Convert.ToString(requestCount);
                    serverResponse = "Server to client(" + clientNo + ") " + rCount;
                    sendByte = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendByte, 0, sendByte.Length);
                    networkStream.Flush();
                    Console.WriteLine(">>>" + serverResponse);
                }catch(Exception ex)
                {
                    Console.WriteLine(">>>"+  ex.ToString());
                }
            }

        }
    }
}
