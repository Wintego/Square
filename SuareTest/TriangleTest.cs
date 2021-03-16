using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;
using System;

namespace SuareTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetSquareTest()
        {
            //arrange
            double a = 5, b = 6, c = 7;
            double expected = 14.696938456699069;
            //act
            var triangle = new Triangle(a, b, c);
            var actual = triangle.GetSquare();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
