using NUnit.Framework;
using FiguresSquare;
using System;

namespace SquareTests
{
    public class SquareTest
    {

        [Test]
        public void RoundSquareTest()
        {
            double R = 2.345;
            Figure figure = new Round(R);
            double expected = Math.PI * R * R;
            double actual = figure.GetSquare();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleSquareTest()
        {
            double A = 4.345;
            double B = 3.456;
            double C = 6.235;
            Figure figure = new Triangle(A, B, C);
            double p = (A + B + C) / 2;
            double expected =  Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            double actual = figure.GetSquare();

            Assert.AreEqual(expected, actual);
        }
    }
}