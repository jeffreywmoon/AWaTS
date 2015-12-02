using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlliedAircraftSystem.Aircraft.Systems
{
    interface ISystem
    {
        bool IsOn { get; set; }

        void Sync();
    }
}
