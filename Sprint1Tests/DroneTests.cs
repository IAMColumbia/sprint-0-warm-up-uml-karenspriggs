using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace Sprint1Tests
{
    [TestClass]
    class DroneTests
    {
        [TestMethod]
        public void DroneAboutTests()
        {
            // Drone Instance to be Tested
            Drone d = new Drone();

            Assert.AreEqual(d.About(), $"This {d.ToString()} has a max altitude of 41000 ft. \nIt's current altitude is 0 ft. \nThis{d.Engine.ToString()}'s engine is not started.");
        }

        [TestMethod]
        public void DroneTakeOffTest()
        {
            // Drone Instance to be Tested
            Drone d = new Drone();

            // Setup
            string firstTakeOff = d.TakeOff();
            d.StartEngine();
            string secondTakeOff = d.TakeOff();
            int altTakeOff = d.CurrentAltitude;

            // Assess
            Assert.AreEqual(d.Engine.isStarted, true);
            Assert.AreEqual(firstTakeOff, $"This {this.ToString()} can't fly it's engine is not started.");
            Assert.AreEqual(secondTakeOff, $"This {this.ToString()} is flying");
            Assert.AreEqual(altTakeOff, 0);
        }

        [TestMethod]
        public void DroneFlyUpTest()
        {
            // Drone Instance to be Tested
            Drone d = new Drone();

            // Setup
            d.StartEngine();
            d.TakeOff();

            // Have to not use custom fly up as the drone's max altitude is only 500
            d.FlyUp(200);
            int defaultFlyUp = d.CurrentAltitude;
            d.FlyUp(200);
            int customFlyUp = d.CurrentAltitude;

            // This should not go up at all since it's too high so it shouldn't change the altitute
            d.FlyUp(100000);
            int limitFlyUp = d.CurrentAltitude;

            // Assess
            Assert.AreEqual(defaultFlyUp, 200);
            Assert.AreEqual(customFlyUp, 400);
            Assert.AreEqual(limitFlyUp, 400);
        }

        [TestMethod]
        public void DroneFlyDownTest()
        {
            // Drone Instance to be Tested
            Drone d = new Drone();

            // Setup
            d.StartEngine();
            d.TakeOff();
            d.FlyUp(500);
            int defaultFlyUp = d.CurrentAltitude;
            d.FlyDown(200);
            int flyDown = d.CurrentAltitude;

            // The value should not change as you are flying down more feet than you are up in the air
            d.FlyDown();
            int limitFlyDown = d.CurrentAltitude;

            d.FlyDown(300);
            int landFlyDown = d.CurrentAltitude;

            // Assess
            Assert.AreEqual(defaultFlyUp, 500);
            Assert.AreEqual(flyDown, 300);
            Assert.AreEqual(limitFlyDown, 300);
            Assert.AreEqual(landFlyDown, 0);
        }
    }
}
