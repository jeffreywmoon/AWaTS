using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlliedAircraftSystem.Aircraft.Systems;

namespace AlliedAircraftSystem.Aircraft
{
    public abstract class Aircraft
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
            targettingSystem = new Systems.TargettingSystem();
            radarSystem = new Systems.RadarSystem();
            weaponSystem = new Systems.WeaponSystem();

            spec = new Specs.Spec();
        }

        public NavPackage Nav
        {
            get { return flightComputer.GetNavData(); }
        }

        public void InternalSync(uint interval)
        {
            flightComputer.NavInternalSync(interval);
        }
    }
}
