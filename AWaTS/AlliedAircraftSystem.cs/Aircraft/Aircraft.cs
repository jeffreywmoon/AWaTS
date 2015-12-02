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

        // spec
        protected Specs.Spec spec;

        // instantiate the systems and spec
        protected void Init()
        {
            flightComputer = new Systems.FlightComputer();
            navSystem = new Systems.NavSystem();
            targettingSystem = new Systems.TargettingSystem();
            radarSystem = new Systems.RadarSystem();
            weaponSystem = new Systems.WeaponSystem();

            spec = new Specs.Spec();
        }
    }
}
