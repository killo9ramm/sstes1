using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSTest1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateTriangle()
        {
           // Triangle t = Triangle.Create(3,4,5,6);
            //Triangle t = Triangle.Create(3, 4, 8);
            Triangle t = Triangle.Create(3, 4, 5);
        }

        [TestMethod]
        public void TestCalculateStrictTriangleSquare()
        {
            Triangle t = Triangle.Create(3, 4, 5);
            int square = t.CalculateStrictTriangleSquare();

            Assert.AreEqual(6, square);
        }
    }
}
