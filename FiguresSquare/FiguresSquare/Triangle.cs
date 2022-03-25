using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class Triangle : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException();

            if(a + b >= c || a + c >= b || b + c >= a)
                throw new ArgumentOutOfRangeException();

            A = a;
            B = b;
            C = c;
        }
        public override double GetSquare()
        {
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsRightAngled()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);
            if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
                return true;
            else
                return false;
        }
    }
}
