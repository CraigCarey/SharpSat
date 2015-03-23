using System;
using NUnit.Framework;

namespace SharpSat
{
    [TestFixture]
    class ProgramTester
    {
        [SetUp]
        public void Begin()
        {
            Console.WriteLine("Setup ProgramTester");
        }

        [TearDown]
        public void End()
        {
            Console.WriteLine("ProgramTester TearDown OK");
        }

        [Test]
        public void TestSatCalc()
        {
            testDish = new Dish(53.55, -2.77);
            testSatellite = new Satellite("TestSat", -27.0);
            testSatellite.CalcDishAngles(testDish.Latitude, testDish.Longitude);

            Assert.AreEqual(209.2, testSatellite.Azimuth, "Azimuth fail");
            Assert.AreEqual(24.9, testSatellite.Elevation, "Elevation fail");
        }

        private Dish testDish;
        private Satellite testSatellite;
    }
}
