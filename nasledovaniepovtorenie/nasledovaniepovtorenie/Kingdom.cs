using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Kingdom : State
    {
        private string king;

        public string King
        {
            get { return king; }
            set
            {
                try
                {
                    if (value == null)
                        throw new ArgumentNullException();
                    king = value;
                }
                catch
                {
                    Console.WriteLine("Пустное значение");
                }
            }
        }

        public Kingdom(string name, string currency, string symbolism, string king) : base(name, currency, symbolism)
        {
            King = king;
        }

        public override string ToString()
        {
            return $"Название: {Name}\nВалюта: {Currency}\nСимволика: {Symbolism}\nКороль: {King}\n";
        }

        public string InfoAboutKingDom(ref string n, ref string kn, out string res)
        {
            res = $"{n} управляется Королём(-евой) {kn}";
            return res;
        }
    }
}
