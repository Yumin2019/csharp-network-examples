//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Project1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // 소캣 생성 및 필요시 소켓 옵션 지정
//            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
//            sock.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 32);

//            // 멀티 캐스트 종단점
//            IPAddress multicastIP = IPAddress.Parse("239.100.100.100");
//            IPEndPoint ep = new IPEndPoint(multicastIP, 5500);

//            // 데이타 송신 
//            byte[] buff = Encoding.ASCII.GetBytes("Hello");
//            sock.SendTo(buff, 0, buff.Length, SocketFlags.None, ep);
//            Console.WriteLine("sent data = Hello");
//            Thread.Sleep(3000);

//            sock.Close();
//            Console.WriteLine("소켓 종료");
//        }
//    }

//}
