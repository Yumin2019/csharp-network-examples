//using System;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;

//namespace UdpCli
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // 1. UdpClient 객체 생성
//            UdpClient cli = new UdpClient();

//            string msg = "안녕하세요";
//            byte[] datagram = Encoding.UTF8.GetBytes(msg);

//            // 2. 데이터 송신
//            cli.Send(datagram, datagram.Length, "127.0.0.1", 7777);
//            Console.WriteLine("[Send] 127.0.0.1:7777로 {0}바이트 전송", datagram.Length);

//            // 3. 데이터 수신
//            IPEndPoint epRemote = new IPEndPoint(IPAddress.Any, 0);
//            byte[] bytes = cli.Receive(ref epRemote);
//            Console.WriteLine("[Receive] {0}로부터 {1} 바이트 수신", epRemote.ToString(), bytes.Length);

//            // 4. udpClient 객체 닫기
//            cli.Close();

//            Console.WriteLine("종료");
//        }
//    }
//}
