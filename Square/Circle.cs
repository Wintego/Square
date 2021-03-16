using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Неверный радиус");
            this.radius = radius;
        }
        double radius;
        public double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
