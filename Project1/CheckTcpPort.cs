
//using System;
//using System.Net;
//using System.Net.NetworkInformation;

//namespace Project1
//{
//    class CheckTcpPort
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("IsTcpPortAvailable(7000) = " + IsTcpPortAvailable(7000));
//        }

//        public static bool IsTcpPortAvailable(int tcpPort)
//        {
//            var ipgp = IPGlobalProperties.GetIPGlobalProperties();
//            TcpConnectionInformation[] conns = ipgp.GetActiveTcpConnections();

//            // Check ActiveConnection ports
//            foreach (var cn in conns)
//            {
//                if (cn.LocalEndPoint.Port == tcpPort)
//                {
//                    Console.WriteLine("사용중");
//                    return false;
//                }
//            }

//            // Check Listening Ports
//            IPEndPoint[] endPoints = ipgp.GetActiveTcpListeners();
//            foreach (var ep in endPoints)
//            {
//                if (ep.Port == tcpPort)
//                {
//                    Console.WriteLine("리스닝중");
//                    return false;
//                }
//            }

//            return true;
//        }
//    }
//}
