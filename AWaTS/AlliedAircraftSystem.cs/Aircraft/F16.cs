using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlliedAircraftSystem.Aircraft.Systems;
/// <summary>
/// SOURCES OF F16 DATA USED:
/// http://www.lockheedmartin.com/us/products/f16/F-16Specifications.html
/// https://en.wikipedia.org/wiki/General_Dynamics_F-16_Fighting_Falcon
/// </summary>
namespace AlliedAircraftSystem.Aircraft
{
    public class F16 : Aircraft
    {
        // some canned start nav data
        NavPackage startNav;

        /// <summary>
        /// Constructor
        /// </summary>
        public F16()
        {
            // hard coded f16 spec settings
            Init();

            spec.MaxRange = 3222.48; // km
            spec.MaxSpeed = 2414.016; // kmh
            spec.CruiseSpeed = 1320.48; // kmh

            startNav = new NavPackage(0.0, 0.0, 10000, 6672, Math.PI/4, 0.0);

            SystemPowerUp(startNav);
        }

        new private void Init()
        {
            base.Init();
        }
        /// <summary>
        /// Powers all systems up
        /// </summary>
        /// <param name="startNav"></param>
        private void SystemPowerUp(NavPackage startNav)
        {
            flightComputer.TurnOnNavComputer(startNav);
        }



        
    }
}
