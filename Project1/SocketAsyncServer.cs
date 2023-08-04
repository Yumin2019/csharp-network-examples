//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Net.WebSockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace SocketAsyncServer
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            RunAsyncSocketServer().Wait();
//        }

//        static async Task RunAsyncSocketServer()
//        {
//            int MAX_SIZE = 1024;

//            // 1. 소켓 객체 생성(TCP 소켓)
//            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            // 2. 포트에 바인드
//            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 7000);
//            socket.Bind(ep);

//            // 3. 포트 리스닝 시작
//            socket.Listen(100);
//            await Console.Out.WriteLineAsync("포트 리스닝");

//            while (true)
//            {
//                // 4. 비동기 소켓 Accept
//                Socket clientSock = await Task.Factory.FromAsync(socket.BeginAccept, socket.EndAccept, null);
//                await Console.Out.WriteLineAsync("client Sock 연결됨");

//                // 5. 비동기 소켓 수신
//                var buff = new byte[MAX_SIZE];

//                int count = await Task.Factory.FromAsync<int>(
//                    clientSock.BeginReceive(buff, 0, buff.Length, SocketFlags.None, null, clientSock),
//                    clientSock.EndReceive);

//                if (count > 0)
//                {
//                    string msg = Encoding.ASCII.GetString(buff, 0, count);
//                    await Console.Out.WriteLineAsync("received msg = " + msg + " count = " + count);

//                    await Task.Factory.FromAsync(
//                        clientSock.BeginSend(buff, 0, buff.Length, SocketFlags.None, null, clientSock),
//                        clientSock.EndSend);
//                    await Console.Out.WriteLineAsync("sent msg = " + msg + " count = " + count);
//                }

//                // 7. 소켓 닫기
//                clientSock.Close();
//            }
//        }


//    }
//}
