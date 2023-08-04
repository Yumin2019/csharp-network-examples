using System;
using System.Net.Http;

namespace Project1
{
    class Ftp
    {
        static void Main(string[] args)
        {
            string user = "kym";
            string pwd = "1234";

            // ftp 업로드
            //using (var client = new WebClient())
            //{
            //    client.Credentials = new NetworkCredential(user, pwd);
            //    client.UploadFile("ftp://localhost/test1.txt", @"C:\Users\user\source\repos\Project1\Project1\bin\Debug\test1.txt");
            //}

            //using (var client = new WebClient())
            //{
            //    client.Credentials = new NetworkCredential(user, pwd);
            //    client.DownloadFile("ftp://localhost/test1.txt", @"C:\Users\user\source\repos\Project1\Project1\bin\Debug\test1FromServer.txt");
            //}


            //string url = "http://www.google.com";

            //WebClient webClient = new WebClient();
            //string html = webClient.DownloadString(url);

            //Console.WriteLine("html = " + html);

        }
    }
}
