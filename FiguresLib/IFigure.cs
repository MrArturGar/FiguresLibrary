using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public interface IFigure
    {
        int NumOfSides { get;}
        public double GetArea();
        public double GetPerimetr();

    }
}
