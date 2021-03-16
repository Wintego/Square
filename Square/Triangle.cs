using System;

namespace Square
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            if (a <= 0) throw new ArgumentException($"Неверный размер стороны {nameof(a)}");
            if (b <= 0) throw new ArgumentException($"Неверный размер стороны {nameof(b)}");
            if (c <= 0) throw new ArgumentException($"Неверный размер стороны {nameof(c)}");
            if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("Такого треугольника не существует!");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        double a, b, c;

        public double GetSquare()
        {
            var halfP = (a + b + c) / 2;
            var square = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
            return square;
        }
    }
}