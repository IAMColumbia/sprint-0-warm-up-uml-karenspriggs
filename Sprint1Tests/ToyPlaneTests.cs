using System;
using System.Collections.Generic;
using System.Text;  
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace Sprint1Tests
{
    [TestClass]
    class ToyPlaneTests
    {
        [TestMethod]
        public void ToyPlaneAboutTest()
        {
            // Toy Plane instance to be tested
            ToyPlane tp = new ToyPlane();

            Assert.AreEqual(tp.About(), $"This {tp.ToString()} has a max altitude of 41000 ft. \nIt's current altitude is 0 ft. \nThis{tp.Engine.ToString()}'s engine is not started.");
        }

        [TestMethod]
        public void ToyPlaneTakeOffTest()
        {
            // Toy Plane instance to be tested
            ToyPlane tp = new ToyPlane();

            // Setup
            string firstTakeOff = tp.TakeOff();
            tp.StartEngine();
            string noWind = tp.getWindUpString();
            tp.WindUp();
            string woundUp = tp.getWindUpString();
            tp.StartEngine();
            string secondTakeOff = tp.TakeOff();
            int altTakeOff = tp.CurrentAltitude;

            // Assess
            Assert.AreEqual(tp.Engine.isStarted, true);
            Assert.AreEqual(firstTakeOff, $"This {this.ToString()} can't fly it's engine is not started.");
            Assert.AreEqual(noWind, $"This {this.ToString()} has not been wound up");
            Assert.AreEqual(woundUp, $"This {this.ToString()} has been wound up");
            Assert.AreEqual(secondTakeOff, $"This {this.ToString()} is flying");
            Assert.AreEqual(altTakeOff, 0);
        }

        [TestMethod]
        public void ToyPlaneFlyUpTest()
        {
            // Toy Plane instance to be tested
            ToyPlane tp = new ToyPlane();

            // Setup
            tp.WindUp();
            tp.StartEngine();
            tp.FlyUp(10);
            int firstFlyUp = tp.CurrentAltitude;
            tp.FlyUp(20);
            int nextFlyUp = tp.CurrentAltitude;

            // This should not go up at all since it's too high so it shouldn't change the altitute
            tp.FlyUp(100000);
            int limitFlyUp = tp.CurrentAltitude;

            // Assess
            Assert.AreEqual(firstFlyUp, 10);
            Assert.AreEqual(nextFlyUp, 20);
            Assert.AreEqual(limitFlyUp, 20);
        }

        [TestMethod]
        public void ToyPlaneFlyDownTest()
        {
            // Toy Plane instance to be tested
            ToyPlane tp = new ToyPlane();

            // Setup
            tp.WindUp();
            tp.StartEngine();
            tp.FlyUp(50);
            int maxFlyUp = tp.CurrentAltitude;
            tp.FlyDown(20);
            int flyDown = tp.CurrentAltitude;

            // The value should not change as you are flying down more feet than you are up in the air
            tp.FlyDown();
            int limitFlyDown = tp.CurrentAltitude;

            tp.FlyDown(30);
            int landFlyDown = tp.CurrentAltitude;

            // Assess
            Assert.AreEqual(maxFlyUp, 50);
            Assert.AreEqual(flyDown, 30);
            Assert.AreEqual(limitFlyDown, 30);
            Assert.AreEqual(landFlyDown, 0);
        }
    }
}
