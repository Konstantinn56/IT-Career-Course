using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3
{
    interface IColoredFigure
    {
        string Color { get; }
        double Size { get; }

        void Show();
        string GetName();
    }
}
