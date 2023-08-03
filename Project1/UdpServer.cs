//using System;
//using System.Net;
//using System.Net.Sockets;

//namespace UdpSrv
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // 1. UdpClient 객체 생성 포트 7777에서 리스닝
//            UdpClient srv = new UdpClient(7777);
//            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

//            while (true)
//            {
//                // 2. 데이터 수신
//                byte[] dgram = srv.Receive(ref remoteEP);
//                Console.WriteLine("[receive] {0}로부터 {1} 바이트 수신", remoteEP.ToString(), dgram.Length);

//                // 3. 데이터 송신
//                srv.Send(dgram, dgram.Length, remoteEP);
//                Console.WriteLine("[send] {0}로부터 {1} 바이트 송신", remoteEP.ToString(), dgram.Length);
//            }
//        }
//    }
//}
