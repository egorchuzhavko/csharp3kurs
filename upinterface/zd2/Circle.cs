using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal class Circle : Dot, iFigure
    {
        public int r;
        public double X1 { get; set; }
        public double Y1 { get; set; }

        public Circle(Dot dot, double x1,double y1): base(dot.X, dot.Y)
        {
            X1 = x1;
            Y1 = y1;
        }
        public new double Square()
        {
            return Math.PI * Math.Pow(Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2)), 2);
        }
    }
}
