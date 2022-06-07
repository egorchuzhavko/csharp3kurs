using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal abstract class Worker : IComparable<Worker>
    {
        public string name;
        protected double salary;
        public int id;

        public Worker(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public abstract void CalcSalary();

        public int CompareTo(Worker? o)
        {
          //  var res = o.salary.CompareTo(salary);
            var res = -salary.CompareTo(o.salary);
            if (res == 0)
                res = name.CompareTo(o.name);
            return res;
        }

        public override string ToString()
        {
            return $"{name} имеет зарплату {salary}\n";
        }
    }
}
