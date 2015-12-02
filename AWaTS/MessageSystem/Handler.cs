using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem
{
    // base class for a message handler
    public abstract class Handler
    {
        // compares checksum actual vs. what the message claims
        protected bool IsValidMessage(byte[] buf)
        {
            return Utilities.CalcChecksum(buf) == GetActualChecksum(buf);
        }

        // returns message type
        protected ushort GetMessageType(byte[] buf)
        {
            return BitConverter.ToUInt16(buf, 0);
        }

        // gets the last 2 bytes of message and converts to ushort
        // this is the checksum that the sender calculated
        // it should be packaged as little endian, just like everything.
        // This is a goddamn little endian machine, and so is every machine that this runs on.
        // So you know what, deal with it.
        private ushort GetActualChecksum(byte[] buf)
        {
            ushort checksum = 0;
            byte[] checksumBytes = { 0, 0 };
            Array.Copy(buf, 26, checksumBytes, 0, 2);
            checksum = BitConverter.ToUInt16(checksumBytes, 0);

            return checksum;
        }
    }
}
