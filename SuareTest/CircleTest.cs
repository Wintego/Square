using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;
using System;

namespace SuareTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetSquareTest()
        {
            //arrange
            var radius = 4;
            var expected = Math.PI * radius * radius;
            //act
            var circle = new Circle(radius);
            var actual = circle.GetSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
