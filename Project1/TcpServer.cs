//using System;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Windows.Forms;

//namespace TcpSrv
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TcpListener listener = new TcpListener(IPAddress.Any, 7000);
//            listener.Start();

//            byte[] buffer = new byte[1024];

//            while (true)
//            {
//                TcpClient tc = listener.AcceptTcpClient();

//                NetworkStream stream = tc.GetStream();

//                int nbytes;
//                while ((nbytes = stream.Read(buffer, 0, buffer.Length)) > 0)
//                {
//                    Console.WriteLine("received: " + Encoding.ASCII.GetString(buffer));
//                    Console.WriteLine("sent received Message to client");
//                    stream.Write(buffer, 0, nbytes);
//                }

//                Console.WriteLine("close stream, close tcpClient");
//                stream.Close();
//                tc.Close();
//            }
//        }
//    }
//}
