using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace EthernetSystem
{
    /// <summary>
    /// Socket for receiving
    /// </summary>
    public class RecvSocket
    {
        // socket object
        private UdpClient rSock;

        // the port that this socket is connected on
        private int myPort;


        // keep connection alive?
        private object boolLock = new object();
        private bool alive = false;
        // thread-safe access to alive
        private bool isAlive
        {
            get
            {
                lock(boolLock)
                {
                    return alive;
                }

            }
            set
            {
                lock(boolLock)
                {
                    alive = value;
                }
            }
        }

        /// <summary>
        /// Init socket
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public int Connect(int port)
        {
            int return_value = (int)Errors.NO_ERRORS;
            try
            {
                // create udp socket
                rSock = new UdpClient(port);
                myPort = port;
            }
            catch(SocketException)
            {
                return_value = (int)Errors.SOCKET_ERROR;
            }
            catch(ArgumentOutOfRangeException)
            {
                return_value = (int)Errors.INVALID_PORT_ERROR;
            }
            catch(Exception)
            {
                return_value = (int)Errors.UNKNOWN_ERROR;
            }

            return return_value;
        }

        /// <summary>
        /// Starts read task
        /// </summary>
        /// <returns></returns>
        public int BeginRead()
        {
            int return_value = (int)Errors.NO_ERRORS;
            isAlive = true;
            if (rSock != null)
            {

                // starts new task to receive
                Task receiveTask = Task.Factory.StartNew(() =>
               {
                   IPEndPoint allIps = new IPEndPoint(IPAddress.Any, myPort);
                   while(isAlive)
                   {
                       byte[] buf = rSock.Receive(ref allIps);
                       // handle(buf)
                       Console.WriteLine(BitConverter.ToString(buf));
                   }
               });
            }
            else
            {
                return_value = (int)Errors.SOCKET_READ_ERROR;
            }

            return return_value; 
        }

        /// <summary>
        /// Stops the read task
        /// </summary>
        /// <returns></returns>
        public int EndRead()
        {
            int return_value = (int)Errors.NO_ERRORS;
            isAlive = false;
            return return_value;
            
        }
    }
}
