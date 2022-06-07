using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Monarchy : State
    {
        private string type;
        private string nameOfMonarch;
        public string Type
        {
            get { return type; }
            set
            {
                try
                {
                    if (value == null)
                        throw new ArgumentNullException();
                    type = value;
                }
                catch
                {
                    Console.WriteLine("Пустное значение");
                }
            }
        }
        public string NameOfMonarch
        {
            get { return nameOfMonarch; }
            set
            {
                try
                {
                    if (value == null)
                        throw new ArgumentNullException();
                    nameOfMonarch = value;
                }
                catch
                {
                    Console.WriteLine("Пустное значение");
                }
            }
        }

        public Monarchy(string name, string currency, string symbolism, string type, string nameOfMonarch) : base(name, currency, symbolism)
        {
            Type = type;
            NameOfMonarch = nameOfMonarch;
        }

        public override string ToString()
        {
            return $"Название: {Name}\nВалюта: {Currency}\nСимволика: {Symbolism}\nВид: {Type}\nИмя монарха: {NameOfMonarch}\n";
        }
    }
}
