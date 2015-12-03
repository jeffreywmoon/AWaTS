using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlliedAircraftSystem.Services
{
    public class MathUtilities
    {
        /// <summary>
        /// returns objects in the X velocity, given the pitch, velocity, and heading
        /// </summary>
        /// <returns></returns>
        public static double GetXVelocity(double velocity, double pitch, double heading)
        {
            return velocity * (Math.Cos(heading) * Math.Cos(pitch));
        }

        /// <summary>
        /// returns objects in the Y velocity, given the pitch, velocity, and heading
        /// </summary>
        /// <returns></returns>
        public static double GetYVelocity(double velocity, double pitch, double heading)
        {
            return velocity * (Math.Sin(heading) * Math.Cos(pitch));
        }

        /// <summary>
        /// returns objects in the Z velocity, given the pitch and velocity
        /// </summary>
        /// <returns></returns>
        public static double GetZVelocity(double velocity, double pitch)
        {
            return velocity * Math.Sin(pitch);
        }

        /// <summary>
        /// change in latitude 
        /// </summary>
        /// <param name="yVel">kmh</param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public static double GetDeltaLat(double yVel, uint interval)
        {
            double metersPerSec = (yVel * 1000) / 3600;
            double meters = metersPerSec * (interval / 1000.0);

            return meters / 110540;
        }

        /// <summary>
        /// Change in longitude
        /// </summary>
        /// <param name="xVel"></param>
        /// <param name="lat"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public static double GetDeltaLon(double xVel, double lat, uint interval)
        {
            double metersPerSec = (xVel * 1000) / 3600;
            double meters = metersPerSec * (interval / 1000.0);

            return (meters / (111320 * Math.Cos(lat)));
        }

        /// <summary>
        /// Change in altitude
        /// </summary>
        /// <param name="zVel"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public static double GetDeltaAlt(double zVel, uint interval)
        {
            double metersPerSec = (zVel * 1000) / 3600;
            return metersPerSec * (interval / 1000.0);
        }
    }
}
