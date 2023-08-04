//using System;
//using System.Drawing;
//using System.Net.Sockets;
//using System.Windows.Forms;

//namespace Project1
//{
//    class TcpScreenCaptureClient
//    {
//        static void Main(string[] args)
//        {
//            int BUFF_SIZE = 1024;
//            string server = "127.0.0.1";
//            int port = 7000;

//            TcpClient tc = new TcpClient(server, port);
//            Console.WriteLine("TCP Client server: localhost, port 7000");

//            Bitmap bmp = ScreenCapture();
//            var imgconv = new ImageConverter();
//            byte[] imgbytes = (byte[])imgconv.ConvertTo(bmp, typeof(byte[]));
//            byte[] nbytes = BitConverter.GetBytes(imgbytes.Length);
//            Console.WriteLine("이미지 캡쳐 & 길이 bytes");

//            using (NetworkStream stream = tc.GetStream())
//            {
//                // 1. 데이터 크기 전달
//                stream.Write(nbytes, 0, nbytes.Length);
//                Console.WriteLine("데이터 크기 전달 length = " +  imgbytes.Length);

//                // 2. 실제 데이터 전달
//                int end = imgbytes.Length;
//                int start = 0;
//                while (start < end)
//                {
//                    int n = end - start >= BUFF_SIZE ? BUFF_SIZE : end - start;
//                    stream.Write(imgbytes, start, n);
//                    start += n;
//                }
//                Console.WriteLine("이미지 바이트 전달 완료");

//                // 3. 결과 수신: 성공이면 1, 실패면 0
//                byte[] result = new byte[1];
//                stream.Read(result, 0, result.Length);
//                Console.WriteLine("결과 수신 result[0] = " + result[0]);
//            }

//            Console.WriteLine("TCP Client 종료");
//            tc.Close();
//        }

//        static Bitmap ScreenCapture()
//        {
//            Rectangle rect = Screen.PrimaryScreen.Bounds;
//            Bitmap scrbmp = new Bitmap(rect.Width, rect.Height);

//            using (Graphics g = Graphics.FromImage(scrbmp))
//            {
//                g.CopyFromScreen(rect.X, rect.Y, 0, 0, scrbmp.Size, CopyPixelOperation.SourceCopy);
//            }

//            return scrbmp;
//        }
//    }
//}
