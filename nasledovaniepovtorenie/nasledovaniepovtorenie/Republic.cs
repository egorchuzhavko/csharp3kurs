using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Republic : State
    {
        private string type;
        private string government;
        private static int count = 0;
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
                    Console.WriteLine("Пустое значение");
                }
            }
        }
        public string Government
        {
            get { return government; }
            set
            {
                try
                {
                    if (value == null)
                        throw new ArgumentNullException();
                    government = value;
                }
                catch
                {
                    Console.WriteLine("Пустное значение");
                }
            }
        }

        public Republic(string name, string currency, string symbolism, string type, string government) : base(name, currency, symbolism)
        {
            Type = type;
            Government = government;
            count++;
        }

        public static void ShowCountOfRepublics()
        {
            Console.WriteLine("Количество республик: " + count);
        }

        public override string ToString()
        {
            return $"Название: {Name}\nВалюта: {Currency}\nСимволика: {Symbolism}\nВид: {Type}\nПравительство: {Government}\n";
        }
    }
}
