using System;
using NUnit.Framework;

namespace SharpSat
{
    class UtilsTester
    {
        [Test]
        public void TestCheckLatitude()
        {
            Assert.IsTrue(Utils.CheckLatitude(90.0));
            Assert.IsTrue(Utils.CheckLatitude(-90.0));
            Assert.IsTrue(Utils.CheckLatitude(0.0));
            Assert.IsFalse(Utils.CheckLatitude(90.1));
            Assert.IsFalse(Utils.CheckLatitude(-90.1));
        }

        [Test]
        public void TestCheckLongitude()
        {
            Assert.IsTrue(Utils.CheckLongitude(-180.0));
            Assert.IsTrue(Utils.CheckLongitude(180.0));
            Assert.IsTrue(Utils.CheckLongitude(0.0));
            Assert.IsFalse(Utils.CheckLongitude(-180.1));
            Assert.IsFalse(Utils.CheckLongitude(180.1));
        }
    }
}
