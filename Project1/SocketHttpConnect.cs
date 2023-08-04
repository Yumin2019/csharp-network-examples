//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Controls;

//namespace Project1
//{
//    class SocketHttpConnect
//    {
//        static void Main(string[] args)
//        {
//            // TCP/IP  소켓 객체 생성
//            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            // 호스트를 IP로 변경
//            IPHostEntry hostEntry = Dns.GetHostEntry("www.naver.com");
//            IPAddress ip = hostEntry.AddressList[0];

//            // HTTP 서버 접속
//            var httpEndPoint = new IPEndPoint(ip, 443);
//            socket.Connect(httpEndPoint);

//            // HTTP header should end with double new line (\r\n\r\n)
//            string http = @"GET www.naver.com HTTP/1.1
//            Host: www.naver.com
//            Connection: keep-alive
//            Cache-Control: max-age=0
//            User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36
//            Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8
//            Accept-Encoding: gzip, deflate
//            Accept-Language: en-US,en;q=0.9
 
//            ";

//            // Send
//            var sendBuff = Encoding.ASCII.GetBytes(http);
//            socket.Send(sendBuff, SocketFlags.None);

//            // Receive
//            byte[] recvBuff = new byte[socket.ReceiveBufferSize];
//            int nCount = socket.Receive(recvBuff);

//            // 파일 저장
//            string result = Encoding.ASCII.GetString(recvBuff, 0, nCount);
//            File.WriteAllText("test.txt", result);

//            socket.Close();
//        }
//    }
//}
