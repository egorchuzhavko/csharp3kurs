using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal class Dot : iFigure
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Dot(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual double Square() { return 0; }
    }
}
