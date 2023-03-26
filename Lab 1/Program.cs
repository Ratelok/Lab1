using System.Net;

namespace SocketTcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip;
            ip = IPAddress.Loopback;
            Console.WriteLine("IP Loopback= "+ ip);
            ip = IPAddress.None;
            Console.WriteLine("IP None = " + ip);
            ip = IPAddress.Any;
            Console.WriteLine("IP Any = " + ip);
            ip = IPAddress.Broadcast;
            Console.WriteLine("IP Broadcast= " + ip);

            ip = IPAddress.Parse("123.45.67.89");
            Console.WriteLine("IP = " + ip.ToString());


            string Host = Dns.GetHostName();
            Console.WriteLine("\nMy comp name = " + Host);

            //самостоятельно вывести информацию про все ip адреса вашего устройства
            Console.WriteLine("All IP in my comp");
            IPAddress[] IPs;

            IPs = Dns.GetHostAddresses(Host);

            //foreach (IPAddress ip1 in IPs)
            IPAddress ip1 = IPs[0];
            Console.WriteLine(ip1);
            Console.WriteLine("Addr family = " + ip1.AddressFamily.ToString());
            IPAddress ip2 = IPs[1];
            Console.WriteLine(ip2);
            Console.WriteLine("Addr family = " + ip2.AddressFamily.ToString());

//11


            IPHostEntry host1 = Dns.GetHostEntry("unn.ru");
            Console.WriteLine("UNN Host name = "+host1.HostName);

            foreach (IPAddress ip0 in host1.AddressList)
                Console.WriteLine("UNN IP = "+ip0.ToString());

            Console.ReadLine();

        }
    }
}