using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class TimeWorker : Worker
    {
        protected double chasoplata;
        public TimeWorker(string name, int id, double chasoplata) : base(name, id) 
        {
            this.chasoplata = chasoplata;
        }

        public override void CalcSalary()
        {
            salary = 20.8 * 8 * chasoplata;
        }
    }
}
