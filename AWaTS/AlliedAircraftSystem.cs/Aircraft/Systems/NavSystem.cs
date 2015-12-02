using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlliedAircraftSystem.Aircraft.Systems
{
    class NavSystem : ISystem
    {
        private double lat; // current latitude
        private double lon; // current longitude
        private double alt; // current altitude

        private double v; // velocity (meters / second)
        private double d; // direction that the aircraft is traveling (radians)

        public bool IsOn { get; set; } 

        public void Sync()
        {

        }
    }
}
