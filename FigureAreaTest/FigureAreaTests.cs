using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureAreaTest
{
    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        public void TestCircleZeroRadius()
        {
            Assert.AreEqual(FigureArea.CircleArea(0), 0);
        }

        [TestMethod]
        public void TestCircleNegativeRadius()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => FigureArea.CircleArea(-123));
        }
        [TestMethod]
        public void TestCirclePositiveRadius()
        {
            double radius = 15;
            Assert.AreEqual(FigureArea.CircleArea(radius), Math.PI * (Math.Pow(radius, 2)));
        }
    }
    [TestClass]
    public class TriangleAreaTests
    {
        [TestMethod]
        public void TestTriangleZeroSides()
        {
            Assert.AreEqual(FigureArea.TriangleArea(1, 1, 0), 0);
            Assert.AreEqual(FigureArea.TriangleArea(0, 1, 1), 0);
            Assert.AreEqual(FigureArea.TriangleArea(1, 0, 1), 0);
        }

        [TestMethod]
        public void TestTriangleNegativeSides()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => FigureArea.TriangleArea(-1, 1, 1));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => FigureArea.TriangleArea(1, -1, 1));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => FigureArea.TriangleArea(1, 1, -1));
        }

        [TestMethod]
        public void TestTrianglePositiveSides()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double halfPerimetr = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimetr * (halfPerimetr - sideA) * (halfPerimetr - sideB) * (halfPerimetr - sideC));
            Assert.AreEqual(FigureArea.TriangleArea(sideA, sideB, sideC), area);
        }
    }
}