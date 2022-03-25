using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class Round : Figure
    {
        public double Radius { get; }
        public Round(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException();

            Radius = radius;
        }
        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
