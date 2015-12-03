using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlliedAircraftSystem.Services;

namespace AWaTSUnitTests
{
    [TestClass]
    public class AircraftSystem
    {
        [TestMethod]
        public void TestLatLonCalculations()
        {
            double startLat = 100;
            double startLon = 100;

            double xVel = 1800; //kmh
            double yVel = 1800; //kmh

            double deltaLat = MathUtilities.GetDeltaLat(yVel, 1000);
            double deltaLon = MathUtilities.GetDeltaLon(xVel, startLat, 1000);

            double meters = deltaLat * 111200;

            Console.WriteLine("deltaLat: {0}\ndeltaLon: {1}\nMeters: {2}", deltaLat, deltaLon, meters);


        }
    }
}
