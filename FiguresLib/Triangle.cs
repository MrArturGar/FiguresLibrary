using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Triangle : IFigure
    {
        private double _a, _b, _c;
        public int NumOfSides { get => 3; }
        public Triangle(double a, double b, double c)
        {

            if ((a + b) < c || (a + c) < b || (b + c) < a)
                throw new FigureException("Incorrect figure parameters");

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetPerimetr()
        {
            return _a + _b + _c;
        }

        public double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public static bool IsStraightTriangle(IFigure figure)
        {
            if (figure is not Triangle)
                throw new FigureException($"A {figure.GetType()} is not a triangle");

            Triangle triangle = (Triangle)figure;

            double[] sides = { triangle._a, triangle._b, triangle._c };
            double hypotenuse = sides.Max();
            int numIndex = Array.IndexOf(sides, hypotenuse);
            double[] cathetus = sides.Where((val, idx) => idx != numIndex).ToArray();

            return Math.Pow(hypotenuse, 2) == (Math.Pow(cathetus[0], 2) + Math.Pow(cathetus[1], 2));
        }

    }
}
