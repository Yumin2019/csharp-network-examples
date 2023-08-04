//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project1
//{
//    class TcpScreenCaptureServer
//    {
//        static void Main(string[] args)
//        {
//            RunServer();
//            Console.ReadLine();
//        }

//        async static void RunServer()
//        {
//            int BUFF_SIZE = 1024;

//            TcpListener listener = new TcpListener(IPAddress.Any, 7000);
//            listener.Start();
//            await Console.Out.WriteLineAsync("7000 포트 리스닝 시작");

//            while (true)
//            {
//                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
//                NetworkStream stream = tc.GetStream();
//                await Console.Out.WriteLineAsync("연결되었음");

//                // 1. 데이터 크기 수신
//                byte[] bytes = new byte[4];
//                int nb = await stream.ReadAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
//                if (nb != 4)
//                {
//                    throw new ApplicationException("Invalid Size");
//                }

//                int total = BitConverter.ToInt32(bytes, 0);

//                // 2. 다음 실제 데이터 수신
//                string filename = Guid.NewGuid().ToString("N") + ".png";
//                using (var fs = new FileStream(filename, FileMode.CreateNew))
//                {
//                    var buff = new byte[BUFF_SIZE];
//                    int received = 0;
//                    while (received  < total)
//                    {
//                        int n = total - received >= BUFF_SIZE ? BUFF_SIZE : total - received;
//                        nb = await stream.ReadAsync(buff, 0, n).ConfigureAwait(false);
//                        received += nb;

//                        // 데이터를 수신해서 filestream에 쓴다.
//                        await fs.WriteAsync(buff, 0, nb);
//                    }
//                }

//                // 3. 성공 여부 송신
//                byte[] result = new byte[1];
//                result[0] = 1; // success
//                await stream.WriteAsync(result, 0, result.Length).ConfigureAwait(false);

//                stream.Close();
//                tc.Close();
//            }
//        }
//    }
//}
