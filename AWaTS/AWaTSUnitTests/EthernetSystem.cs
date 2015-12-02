using System;
using System.Net.Sockets;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EthernetSystem;
namespace AWaTSUnitTests
{
    [TestClass]
    public class EthernetSystem
    {
        private const string localhost = "127.0.0.1";
        private const int sendPort = 6001;
        private const int recvPort = 6000;
        
        [TestMethod]
        public void TestReadTask()
        {
            SendSocket sSock = new SendSocket();
            sSock.Connect(localhost, recvPort, sendPort);

            RecvSocket rSock = new RecvSocket();
            rSock.Connect(recvPort);
            rSock.BeginRead();

            for(int i = 0; i < 10; ++i)
            {
                System.Threading.Thread.Sleep(1000);
                SendString(sSock,String.Format("{0} : Hello World", i));
            }
        }

        
        [TestMethod]
        public void TestStopRead()
        {
            SendSocket sSock = new SendSocket();
            sSock.Connect(localhost, recvPort, sendPort);

            RecvSocket rSock = new RecvSocket();
            rSock.Connect(recvPort);
            rSock.BeginRead();

            for(int i = 1; i < 11; ++i)
            {
                System.Threading.Thread.Sleep(1000);
                // kill read half way through
                if(i % 5 == 0)
                {
                    rSock.EndRead();
                }
                SendString(sSock, String.Format("{0} : Hello World", i));
            }
        }

        // sends a string lol
        private void SendString(SendSocket sendSock, string message)
        {
            sendSock.Send(message);
        }
    }
}
