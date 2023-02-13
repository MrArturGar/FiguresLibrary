using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Rectangle : IFigure
    {
        private double _height, _width;
        public int NumOfSides { get => 4; }

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width; 
        }

        public virtual double GetPerimetr()
        {
            return 2*(_height + _width);
        }

        public virtual double GetArea()
        {
            return _height *_width;
        }
    }
}
