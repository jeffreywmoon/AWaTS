using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlliedAircraftSystem.Aircraft.Systems
{
     public class FlightComputer 
    {
        private NavSystem navSystem;

        public FlightComputer()
        {

        }

        // initialize the nav computer
        public void TurnOnNavComputer(NavPackage startNavData)
        {
            navSystem = new NavSystem(startNavData);
        }

        // return nav data
        public NavPackage GetNavData()
        {
            return navSystem.GetNavData();
        }

        public void NavInternalSync(uint interval)
        {
            navSystem.InternalSync(interval);
        }
    }
}
