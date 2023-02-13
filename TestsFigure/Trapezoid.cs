using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFigure
{
    public class Trapezoid : IFigure
    {
        private double _a, _b, _c, _d;

        public Trapezoid(double a, double b, double c, double d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public int NumOfSides => 4;

        public double GetArea()
        {
            return ((_a + _b) / 2) * Math.Sqrt(Math.Pow(_c, 2) - (Math.Pow((Math.Pow((_b - _a), 2) + Math.Pow(_c, 2) - Math.Pow(_d, 2)) / (2 * (_b - _a)), 2)));

        }


        public double GetPerimetr()
        {
            return _a + _b + _c + _d;
        }
    }
}
