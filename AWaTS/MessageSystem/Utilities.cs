using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem
{
    class Utilities
    {
        public static ushort CalcChecksum(byte[] buf)
        {
            ushort checksum = 0;
            for (int i = 0; i < buf.Length - 2; i += 2)
            {
                checksum ^= buf[i];
                checksum ^= (ushort)((uint)buf[i + 1] << 8);
            }

            return checksum;
        }
    }
}
