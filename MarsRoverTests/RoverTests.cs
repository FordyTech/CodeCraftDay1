using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsTests
{
    [TestClass]
    public class RoverTests
    {
        [DataRow("N","E")]
        [DataRow("E","S")]
        [DataRow("S","W")]
        [DataRow("W","N")]
        [DataTestMethod]
        public void TurnRight(string startDirection, string endDirection)
        {
            var rover = new Rover(startDirection, 0,0);

            rover.Go("R");

            Assert.AreEqual(endDirection, rover.Direction);
        }

        [DataRow("N","W")]
        [DataRow("W", "S")]
        [DataRow("S", "E")]
        [DataRow("E","N")]
        [DataTestMethod]
        public void TurnLeft(string startDirection, string endDirection)
        {
            var rover = new Rover(startDirection, 0,0);

            rover.Go("L");

            Assert.AreEqual(endDirection, rover.Direction);
        }

        [TestMethod]
        public void FaceNorthGoForwardOne()
        {
            var rover = new Rover("N",0,0);

            rover.Go("F");

            Assert.AreEqual("N", rover.Direction);
            Assert.AreEqual(1, rover.YCoord);
        }

    }
}