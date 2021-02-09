using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace Sprint1Tests
{
    [TestClass]
    class EngineTests
    {
        [TestMethod]
        public void EngineTestStartStop()
        {
            // Setup
            Engine e = new Engine();

            bool defaultStarted = e.isStarted;
            e.Start();
            bool methodStarted = e.isStarted;
            e.Stop();
            bool methodStopped = e.isStarted;

            // Tests
            Assert.AreEqual(defaultStarted, false);
            Assert.AreEqual(methodStarted, true);
            Assert.AreEqual(methodStopped, false);
        }

        [TestMethod]
        public void EngineTestAbout()
        {
            // Setup

            Engine e = new Engine();

            string defaultAbout = e.About();
            e.Start();
            string startAbout = e.About();
            e.Stop();
            string stopAbout = e.About();

            // Tests
            Assert.AreEqual(defaultAbout, "This engine has not been started");
            Assert.AreEqual(startAbout, "This engine has been started");
            Assert.AreEqual(stopAbout, "This engine has not been started");
        }
    }
}
