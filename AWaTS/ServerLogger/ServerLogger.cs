using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace ServerLogger
{
    class ServerLogger
    {
        public static int SERVERPORT = 22022;
        static void Main(string[] args)
        {
            BeginRead("127.0.0.1", 22022);
        }

        static void BeginRead(string ip, int port)
        {
            // i guess go forever
            UdpClient u = new UdpClient(port);
            IPEndPoint ipEp = new IPEndPoint(IPAddress.Parse(ip), port);
            while(true)
            {
                byte[] b = u.Receive(ref ipEp);
                PrintMessage(b);
            }
        }

        static void PrintMessage(byte[] b)
        {
            Console.WriteLine(
                String.Format("{0}: {1}", DateTime.Now.ToString(), System.Text.Encoding.ASCII.GetString(b)));
        }
    }
}
