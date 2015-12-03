using AlliedAircraftSystem.Services;

namespace AlliedAircraftSystem.Aircraft.Systems
{
    struct NavPackage
    {
        double Lat;
        double Lon;
        double Alt;
        double V;
        double D;
        double Pitch;
    }
    class NavSystem 
    {
        private double lat; // current latitude
        private double lon; // current longitude
        private double alt; // current altitude

        private double v; // velocity (meters / second)
        private double b; // bearing, North = 0 

        private double pitch; // pitch (radians)

        public bool IsOn { get; set; } 

        public void Sync(double lat, double lon, double alt, double v, double b, double pitch)
        {
            this.lat = lat;
            this.lon = lon;
            this.alt = alt;
            this.v = v;
            this.b = b;
            this.pitch = pitch;
        }

        public void InternalSync(uint interval)
        {
            alt += v * ((MathUtilities.GetZVelocity(v, pitch) * 1000) * (interval / 100;
            lon +=
        }
    }
}
