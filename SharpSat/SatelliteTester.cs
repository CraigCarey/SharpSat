using System;
using NUnit.Framework;

namespace SharpSat
{
    [TestFixture]
    public class SatelliteTester
    {
        [SetUp]
        public void Begin()
        {
            Console.WriteLine("Setup SatelliteTester");
            testSatellite = new Satellite("TestSat", 13);
        }

        [TearDown]
        public void End()
        {
            System.Console.WriteLine("SatelliteTester TearDown OK");
        }

        [Test]
        public void TestSatelliteConstructor()
        {
            testSatellite = new Satellite("test", 253.55);
            Assert.AreEqual(0.0, testSatellite.Longitude, "Longitude oob fail");

            testSatellite = new Satellite("test", -253.55);
            Assert.AreEqual(0.0, testSatellite.Longitude, "Longitude oob fail");

            testSatellite = new Satellite("test", -53.55);
            Assert.AreEqual(-53.55, testSatellite.Longitude, "Longitude set fail");
        }

        [Test]
        public void TestDishAngles()
        {
            testSatellite.CalcDishAngles(13.0, -2.0);
            Assert.AreEqual(130.0, testSatellite.Azimuth, "Azimuth incorrect");
            Assert.AreEqual(66.8, testSatellite.Elevation, "Elevation incorrect");

            testSatellite = new Satellite("TestSat", -27);
            testSatellite.CalcDishAngles(-43.0, 11.0);
            Assert.AreEqual(311.1, testSatellite.Azimuth, "Azimuth incorrect");
            Assert.AreEqual(27.5, testSatellite.Elevation, "Elevation incorrect"); 
        }

        private Satellite testSatellite;
    }
}
