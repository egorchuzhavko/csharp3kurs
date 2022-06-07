using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class FixedWorker : Worker
    {
        private double fix;
        public FixedWorker(string name, int id, double fix) : base(name, id)
        {
            this.fix = fix;
        }

        public override void CalcSalary()
        {
            salary = fix;
        }
    }
}
