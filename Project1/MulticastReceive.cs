//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project1
//{
//    class MulticastReceive
//    {
//        static void Main(string[] args)
//        {
//            // 1. Udp 클라이언트 객체 생성
//            UdpClient udp = new UdpClient();

//            // 2. UPD 로컬 IP포트에 바인딩
//            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 5500);
//            udp.Client.Bind(localEP);
//            Console.WriteLine("바인딩");

//            // 3. 멀티 캐스트 그룹에 Join
//            IPAddress multicastIP = IPAddress.Parse("229.1.1.229");
//            udp.JoinMulticastGroup(multicastIP);
//            Console.WriteLine("조인 멀티캐스트 그룹");

//            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

//            while(!Console.KeyAvailable)
//            {
//                // 4. 멀티캐스트 수신
//                byte[] buff = udp.Receive(ref remoteEP);

//                string data = Encoding.ASCII.GetString(buff, 0, buff.Length);
//                Console.WriteLine("received data = " + data);
//            }
//        }
//    }
//}
