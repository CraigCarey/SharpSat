using System;
using NUnit.Framework;

namespace SharpSat
{
    [TestFixture]
    class DishTester
    {
        [SetUp]
        public void Begin()
        {
            Console.WriteLine("Setup DishTester");
        }

        [TearDown]
        public void End()
        {
            Console.WriteLine("DishTester TearDown OK");
        }

        [Test]
        public void TestDishConstructor()
        {
            testDish = new Dish(253.55, -182.77);
            Assert.AreEqual(0.0, testDish.Latitude, "Latitude oob fail");

            testDish = new Dish(53.55, -182.77);
            Assert.AreEqual(0.0, testDish.Longitude, "Longitude oob fail");

            testDish = new Dish(53.55, -2.77);
            Assert.AreEqual(53.55, testDish.Latitude, "Latitude set fail");
            Assert.AreEqual(-2.77, testDish.Longitude, "Longitude set fail");
        }

        private Dish testDish;
    }
}
