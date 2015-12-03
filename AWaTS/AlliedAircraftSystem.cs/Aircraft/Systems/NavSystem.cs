using AlliedAircraftSystem.Services;

namespace AlliedAircraftSystem.Aircraft.Systems
{
    public struct NavPackage
    {
        public double Lat;
        public double Lon;
        public double Alt;
        public double V;
        public double B;
        public double Pitch;

        // constructor to init all fields
        public NavPackage(double lat, double lon, double alt, double v, double b, double pitch)
        { Lat = lat;  Lon = lon; Alt = alt; V = v; B = b; Pitch = pitch; }
    }
    public class NavSystem 
    {
        private double lat; // current latitude
        private double lon; // current longitude
        private double alt; // current altitude

        private double v; // velocity (meters / second)
        private double b; // bearing, North = 0 

        private double pitch; // pitch (radians)

        public bool IsOn { get; set; } 

        // constructor
        public NavSystem(NavPackage startNav)
        {
            lat = startNav.Lat;
            lon = startNav.Lon;
            alt = startNav.Alt;
            v = startNav.V;
            b = startNav.B;
            pitch = startNav.Pitch;
            IsOn = true;
        }

        public NavPackage GetNavData()
        {
            return new NavPackage(lat, lon, alt, v, b, pitch);
        }

        public void Sync(NavPackage navData)
        {
            lat = navData.Lat;
            lon = navData.Lon;
            alt = navData.Alt;
            v = navData.V;
            b = navData.B;
            pitch = navData.Pitch;
        }

        public void InternalSync(uint interval)
        {
            alt += MathUtilities.GetDeltaAlt(MathUtilities.GetZVelocity(v, pitch), interval);
            lon += MathUtilities.GetDeltaLon(MathUtilities.GetXVelocity(v, pitch, b), lat, interval);
            lat += MathUtilities.GetDeltaLat(MathUtilities.GetYVelocity(v, pitch, b), interval);
        }
    }
}
