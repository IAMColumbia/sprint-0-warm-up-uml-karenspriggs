using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace Sprint1Tests
{
    [TestClass]
    class HelicopterTests
    {
        [TestMethod]
        public void HelicopterAboutTest()
        {
            // Helicopter Instance to be Tested
            Helicopter h = new Helicopter();

            Assert.AreEqual(h.About(), $"This {h.ToString()} has a max altitude of 41000 ft. \nIt's current altitude is 0 ft. \nThis{h.Engine.ToString()}'s engine is not started.");
        }

        [TestMethod]
        public void HelicopterTakeOffTest()
        {
            // Helicopter Instance to be Tested
            Helicopter h = new Helicopter();

            // Setup
            string firstTakeOff = h.TakeOff();
            h.StartEngine();
            string secondTakeOff = h.TakeOff();
            int altTakeOff = h.CurrentAltitude;

            // Assess
            Assert.AreEqual(h.Engine.isStarted, true);
            Assert.AreEqual(firstTakeOff, $"This {this.ToString()} can't fly it's engine is not started.");
            Assert.AreEqual(secondTakeOff, $"This {this.ToString()} is flying");
            Assert.AreEqual(altTakeOff, 0);
        }

        [TestMethod]
        public void HelicopterFlyUpTest()
        {
            // Helicopter Instance to be Tested
            Helicopter h = new Helicopter();

            // Setup
            h.StartEngine();
            h.TakeOff();

            // Have to not use custom fly up as the drone's max altitude is only 500
            h.FlyUp();
            int defaultFlyUp = h.CurrentAltitude;
            h.FlyUp(2000);
            int customFlyUp = h.CurrentAltitude;

            // This should not go up at all since it's too high so it shouldn't change the altitute
            h.FlyUp(100000);
            int limitFlyUp = h.CurrentAltitude;

            // Assess
            Assert.AreEqual(defaultFlyUp, 1000);
            Assert.AreEqual(customFlyUp, 3000);
            Assert.AreEqual(limitFlyUp, 3000);
        }

        [TestMethod]
        public void HelicopterFlyDownTest()
        {
            // Helicopter Instance to be Tested
            Helicopter h = new Helicopter();

            // Setup
            h.StartEngine();
            h.TakeOff();
            h.FlyUp();
            int defaultFlyUp = h.CurrentAltitude;
            h.FlyDown(200);
            int flyDown = h.CurrentAltitude;

            // The value should not change as you are flying down more feet than you are up in the air
            h.FlyDown(100000);
            int limitFlyDown = h.CurrentAltitude;

            h.FlyDown(800);
            int landFlyDown = h.CurrentAltitude;

            // Assess
            Assert.AreEqual(defaultFlyUp, 1000);
            Assert.AreEqual(flyDown, 800);
            Assert.AreEqual(limitFlyDown, 800);
            Assert.AreEqual(landFlyDown, 0);
        }
    }
}
