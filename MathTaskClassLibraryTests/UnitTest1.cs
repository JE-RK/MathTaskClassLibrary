using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void CylinderVolume_12and50()
        {
            double r = 12;
            double h = 50;
            double expected = 22619.46710584651;
            Geometry g = new Geometry();
            Assert.IsTrue(Math.Abs(expected - g.CylinderVolume(h, r)) < 1e-9);
        }
        [TestMethod]
        public void CylinderVolume1()
        {
            double r = -12;
            double h = 50;
            double expected = 22619.46710584651;
            Geometry g = new Geometry();
            Assert.IsTrue(Math.Abs(expected - g.CylinderVolume(h, r)) < 1e-9);
        }
        [TestMethod]
        public void CylinderVolume2()
        {
            double r = 0;
            double h = 25;
            double expected = 22619.46710584651;
            Geometry g = new Geometry();
            Assert.IsTrue(Math.Abs(expected - g.CylinderVolume(h, r)) < 1e-9);
        }
        [TestMethod]
        public void CylinderVolume3()
        {
            double r = 56;
            double h = 0;
            double expected = 0;
            Geometry g = new Geometry();
            Assert.IsTrue(Math.Abs(expected - g.CylinderVolume(h, r)) < 1e-9);
        }
        [TestMethod]
        public void CylinderVolume4()
        {
            double r = 56;
            double h = 100;
            double expected = 5185.8304;
            Geometry g = new Geometry();
            Assert.IsTrue(Math.Abs(expected - g.CylinderVolume(h, r)) < 1e-9);
        }
        [TestMethod]
        public void CylinderVolume5()
        {
            double r = -56;
            double h = -100;
            double expected = 22619.46710584;
            Geometry g = new Geometry();
            Assert.IsTrue(Math.Abs(expected - g.CylinderVolume(h, r)) < 1e-9);
        }
    }
}
