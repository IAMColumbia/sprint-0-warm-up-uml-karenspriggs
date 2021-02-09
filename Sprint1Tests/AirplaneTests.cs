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
        [TestMethod]
        public void AirplaneAboutTest()
        {
            // Airplane Instance to be Tested
            Airplane a = new Airplane();

            Assert.AreEqual(a.About(), $"This {a.ToString()} has a max altitude of 41000 ft. \nIt's current altitude is 0 ft. \nThis{a.Engine.ToString()}'s engine is not started.");
        }

        [TestMethod]
        public void AirplaneTakeOffTest()
        {
            // Airplane Instance to be Tested
            Airplane a = new Airplane();

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
            // Airplane Instance to be Tested
            Airplane a = new Airplane();

            // Setup
            a.StartEngine();
            a.TakeOff();
            a.FlyUp();
            int defaultFlyUp = a.CurrentAltitude;
            a.FlyUp(3000);
            int customFlyUp = a.CurrentAltitude;

            // This should not go up at all since it's too high so it shouldn't change the altitute
            a.FlyUp(100000);
            int limitFlyUp = a.CurrentAltitude;

            // Assess
            Assert.AreEqual(defaultFlyUp, 1000);
            Assert.AreEqual(customFlyUp, 4000);
            Assert.AreEqual(limitFlyUp, 4000);
        }

        [TestMethod]
        public void AirplaneFlyDownTest()
        {
            // Airplane Instance to be Tested
            Airplane a = new Airplane();

            // Setup
            a.StartEngine();
            a.TakeOff();
            a.FlyUp();
            int defaultFlyUp = a.CurrentAltitude;
            a.FlyDown(500);
            int flyDown = a.CurrentAltitude;
            
            // The value should not change as you are flying down more feet than you are up in the air
            a.FlyDown();
            int limitFlyDown = a.CurrentAltitude;

            a.FlyDown(500);
            int landFlyDown = a.CurrentAltitude;

            // Assess
            Assert.AreEqual(defaultFlyUp, 1000);
            Assert.AreEqual(flyDown, 500);
            Assert.AreEqual(limitFlyDown, 500);
            Assert.AreEqual(landFlyDown, 0);
        }
    }
}
