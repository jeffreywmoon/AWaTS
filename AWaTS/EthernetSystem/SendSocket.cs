using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace EthernetSystem
{
    public class SendSocket
    {
        private UdpClient sSock;
        private IPEndPoint endpoint;

        // it's udp, I get that it doesn't actually connect
        // but this is what this function is getting named.
        public void Connect(string remoteIP, int remotePort, int localPort)
        {
            sSock = new UdpClient(localPort);
            IPAddress ipAddr;
            bool success = IPAddress.TryParse(remoteIP, out ipAddr);
            if (success)
            {
                try
                {
                    endpoint = new IPEndPoint(ipAddr, remotePort);
                }
                catch (Exception)
                {
                    // awkward...
                }
            }
        }

        /// <summary>
        /// Sends string
        /// </summary>
        /// <param name="s"></param>
        public void Send(string s)
        {
            byte[] b = System.Text.Encoding.ASCII.GetBytes(s);
            sSock.Send(b, b.Length, endpoint);
        }

        /// <summary>
        /// Sends byte array
        /// </summary>
        /// <param name="b"></param>
        public void Send(byte[] b)
        {
            sSock.Send(b, b.Length, endpoint);
        }

        

    }
}
