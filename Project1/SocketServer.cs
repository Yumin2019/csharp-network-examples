//using System;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;

//namespace SocketSrv
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // 1. 소켓 객체 생성(TCP 소켓)
//            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            // 2. 포트에 바인드
//            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 7000);
//            sock.Bind(ep);

//            // 3. 포트 리스닝 시작
//            sock.Listen(10);
//            Console.WriteLine("포트 리스닝 시작(연결 대기)");

//            // 4. 연결을 받아들여 새 소켓 생성(하나의 연결만 받아들임)
//            Socket clientSocket = sock.Accept();
//            Console.WriteLine("연결되었음");

//            byte[] buff = new byte[8192];
//            while (!Console.KeyAvailable)
//            {
//                // 5. 소켓 수신
//                int n = clientSocket.Receive(buff);
//                if(n == 0)
//                {
//                    continue;
//                }

//                string data = Encoding.UTF8.GetString(buff, 0, n);
//                Console.WriteLine("received: " + data);

//                // 6. 소켓 송신
//                clientSocket.Send(buff, 0, n, SocketFlags.None); // echo
//                Console.WriteLine("sent: " + data);
//            }

//            // 7. 소켓 닫기
//            clientSocket.Close();
//            sock.Close();
//        }
//    }
//}
