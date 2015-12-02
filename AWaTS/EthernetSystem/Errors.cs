using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetSystem
{
    public enum Errors : int
    {
       NO_ERRORS = 0,
       CONNECTION_ERROR,
       SOCKET_ERROR,
       SOCKET_READ_ERROR,
       SOCKET_WRITE_ERROR,
       INVALID_PORT_ERROR,
       INVALID_IP_ERROR,
       UNKNOWN_ERROR,
    }
}
