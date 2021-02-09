using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;


namespace Sprint1Tests
{
    [TestClass]
    class AirplaneTests
    {
        // Airplane Instance to be Tested
        Airplane a = new Airplane();

        [TestMethod]
        public void AirplaneAboutTest()
        {
            Assert.AreEqual(a.About(), $"This {a.ToString()} has a max altitude of 41000 ft. \nIt's current altitude is 0 ft. \nThis{a.Engine.ToString()}'s engine is not started.");
        }

        [TestMethod]
        public void AirplaneTakeOffTest()
        {
            // Setup
            string firstTakeOff = a.TakeOff();
            a.StartEngine();
            string secondTakeOff = a.TakeOff();
            int altTakeOff = a.CurrentAltitude;

            // Assess
            Assert.AreEqual(a.Engine.isStarted, true);
            Assert.AreEqual(firstTakeOff, $"This {this.ToString()} can't fly it's engine is not started.");
            Assert.AreEqual(secondTakeOff, $"This {this.ToString()} is flying");
            Assert.AreEqual(altTakeOff, 0);
        }

        [TestMethod]
        public void AirplaneFlyUpTest()
        {
            // Setup
            a.FlyUp();
        }

        [TestMethod]
        public void AirplaneFlyDownTest()
        {

        }
    }
}
