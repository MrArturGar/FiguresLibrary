using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Circle : IFigure
    {
        private double _radius;
        public int NumOfSides { get => 0; }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetPerimetr()
        {
            return 2 * Math.PI * _radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius;
        }
    }
}
