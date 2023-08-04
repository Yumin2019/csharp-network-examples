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
//    class SocketMulticastReceiver
//    {
//        static void Main(string[] args)
//        {
//            // 소켓 생성 및 필요시 소켓 옵션 지정
//            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

//            // 소켓 바인드
//            sock.Bind(new IPEndPoint(IPAddress.Any, 5500));
//            Console.WriteLine("소켓 바인드");

//            // 멀티캐스트 그룹에 가입
//            IPAddress multicastIP = IPAddress.Parse("239.100.100.100");
//            sock.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(multicastIP, IPAddress.Any));
//            Console.WriteLine("멀티캐스트 그룹에 가입");

//            byte[] buff = new byte[1024];
//            EndPoint ep = new IPEndPoint(IPAddress.Any, 0);

//            // 데이타 수신
//            int n = sock.ReceiveFrom(buff, 0, buff.Length, SocketFlags.None, ref ep);
//            Console.WriteLine("received data = " + Encoding.ASCII.GetString(buff, 0, buff.Length));

//            // 멀티캐스트 그룹에서 탈퇴
//            Thread.Sleep(3000);
//            sock.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DropMembership, new MulticastOption(multicastIP, IPAddress.Any));
//            sock.Close();
//            Console.WriteLine("멀티캐스트 그룹에서 탈퇴");
//        }
//    }
//}
