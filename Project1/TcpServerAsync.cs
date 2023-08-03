//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace TcpSrvAsync
//{
//    class TcpServerAsync
//    {
//        static int clientCnt = 0;

//        static void Main(string[] args)
//        {
//            AsyncEchoServer().Wait();
//        }

//        async static Task AsyncEchoServer()
//        {
//            TcpListener listener = new TcpListener(IPAddress.Any, 7000);
//            listener.Start();

//            while (true)
//            {
//                // 비동기 Accpet
//                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);

//                // 새 쓰레드에서 처리
//                Task.Factory.StartNew(AsyncTcpProcess, tc);
//            }
//        }

//        async static void AsyncTcpProcess(object o)
//        {
//            await Console.Out.WriteLineAsync("client entered");
//            await Console.Out.WriteLineAsync("client cnt: " + ++clientCnt);
//            TcpClient client = (TcpClient)o;

//            int MAX_SIZE = 1024;
//            NetworkStream stream = client.GetStream();

//            var buff = new byte[MAX_SIZE];
//            var nbytes = await stream.ReadAsync(buff, 0, buff.Length).ConfigureAwait(false);
//            if (nbytes > 0)
//            {
//                string msg = Encoding.ASCII.GetString(buff, 0, nbytes);
//                await Console.Out.WriteLineAsync($"{msg} at {DateTime.Now}");

//                // 비동기 통신
//                await stream.WriteAsync(buff, 0, nbytes).ConfigureAwait(false);
//            }

//            stream.Close();
//            client.Close();

//            await Console.Out.WriteLineAsync("client exited");
//            await Console.Out.WriteLineAsync("client cnt: " + --clientCnt);
//        }
//    }
//}
