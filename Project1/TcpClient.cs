
//using System;
//using System.IO;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;

//namespace TcpCli
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TcpClient tc = new TcpClient("localhost", 7000);

//            string msg = "Hello World";
//            byte[] buffer = Encoding.ASCII.GetBytes(msg);

//            Thread.Sleep(3000);
//            NetworkStream stream = tc.GetStream();
//            stream.Write(buffer, 0, buffer.Length);
//            Console.WriteLine("Msg: Hello World is sent to stream");

//            //byte[] outbuf = new byte[1024];
//            //int nbytes;
//            //MemoryStream mem = new MemoryStream();
//            //while ((nbytes = stream.Read(outbuf, 0, outbuf.Length)) > 0)
//            //{
//            //    mem.Write(outbuf, 0, nbytes);
//            //}

//            //byte[] outbytes = mem.ToArray();
//            //mem.Close();

//            //int nbytes = stream.Read(outbuf, 0, outbuf.Length);
//            //string output = Encoding.ASCII.GetString(outbuf, 0, nbytes);

//            stream.Close();
//            tc.Close();

//            //Console.WriteLine("outputs: " + Encoding.ASCII.GetString(outbytes));
//            //Console.WriteLine("close stream, close tcpClient");
//            //Console.WriteLine($"received data {nbytes} bytes: {output}");
//        }
//    }
//}
