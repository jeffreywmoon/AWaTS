using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EthernetSystem;

namespace AWaTSUnitTests
{
    [TestClass] 
    public class ServerLogger
    {
        private string serverIp = "127.0.0.1";
        private int serverPort = 22022;
        private int localPort = 22020;
        [TestMethod]
        public void TestServerLogger()
        {
            SendSocket s = new SendSocket();
            s.Connect(serverIp, serverPort, localPort);
            s.Send("HELLO WORLD!");
            s.Send("CAN YOU HEAR ME?");

            System.Threading.Thread.Sleep(4000);

            s.Send("HELLO..?");
        }
    }
}
