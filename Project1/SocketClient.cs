//using System;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;

//namespace SocketClient
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // 1. 소켓 객체 생성(TCP 소켓)
//            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            // 2. 서버에 연결
//            var ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);
//            sock.Connect(ep);

//            string cmd = string.Empty;
//            byte[] receiverBuff = new byte[8192];

//            Console.WriteLine("connected... Enter Q to exit");

//            while ((cmd = Console.ReadLine()) != "Q")
//            {
//                byte[] buff = Encoding.UTF8.GetBytes(cmd);

//                // 3. 서버에 데이터 전송
//                sock.Send(buff, SocketFlags.None);
//                Console.WriteLine("sent cmd = " + cmd);

//                // 4. 서버에서 데이터 수신
//                int n = sock.Receive(receiverBuff);

//            }

//            sock.Close();
//        }
//    }
//}
