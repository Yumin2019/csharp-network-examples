//using Renci.SshNet;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project1
//{
//    class SshCli
//    {
//        static void Main(string[] args)
//        {
//            var ci = new ConnectionInfo("test.com", "user", new PasswordAuthenticationMethod("user", "pwd"));
//            var cli = new SshClient(ci);
//            cli.Connect();

//            // 1. 간단한 표현
//            var output = cli.CreateCommand("ls -al").Execute();
//            Console.WriteLine("output = " + output);

//            // 2. SshCommand 객체 변수 사용
//            // Dispose 할 수 있고, ExitStatus 같은 속성 체크 가능
//            using (SshCommand cmd = cli.CreateCommand("cat .profile"))
//            {
//                output = cmd.Execute();
//                Console.WriteLine($"ExitStatus: {cmd.ExitStatus}");
//                Console.WriteLine("output = " + output);
//            }

//            // 3. RunCommand() 사용 SshCommand 생성하고 실행
//            SshCommand cmd2 = cli.RunCommand("cat .profile");
//            if (cmd2.ExitStatus == 0)
//            {
//                Console.WriteLine("cmd2.Result: " + cmd2.Result);
//            }

//            cmd2.Dispose();
//            cli.Dispose();
//        }
//    }
//}
