using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlliedAircraftSystem.Aircraft
{
    abstract class Aircraft
    {
        // aircraft systems
        protected Systems.FlightComputer flightComputer;
        protected Systems.NavSystem navSystem;
        protected Systems.TargettingSystem targettingSystem;
        protected Systems.RadarSystem radarSystem;
        protected Systems.WeaponSystem weaponSystem;
    }
}
