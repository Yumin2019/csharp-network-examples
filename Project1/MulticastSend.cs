//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Security.Policy;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Project1
//{
//    class MulticastSend
//    {
//        static void Main(string[] args)
//        {
//            // 1. UdpClient 객체 생성
//            UdpClient udp = new UdpClient();

//            // 2. Multicast 종단점 설정
//            IPEndPoint multicastEP = new IPEndPoint(IPAddress.Parse("229.1.1.229"), 5500);

//            for (int i = 1; i <= 60; ++i)
//            {
//                byte[] dgram = Encoding.ASCII.GetBytes("Msg#" + i);

//                // 3. Multicast 그룹에 데이터그램 전송
//                udp.Send(dgram, dgram.Length, multicastEP);

//                Console.WriteLine("Msg#" + i);
//                Thread.Sleep(1000);
//            }
//        }

//    }
//}
