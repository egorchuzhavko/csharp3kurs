using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal abstract class State
    {
        private string name;
        private string currency;
        private string symbolism;

        public string Name
        {
            get { return name; }
            set {
                try
                {
                    if (value == null)
                        throw new ArgumentNullException();
                    name = value;
                }
                catch
                {
                    Console.WriteLine("Пустное значение");
                }
            }
        }
        public string Currency
        {
            get { return currency; }
            set
            {
                try
                {
                    if (value == null)
                        throw new ArgumentNullException();
                    currency = value;
                }
                catch
                {
                    Console.WriteLine("Пустное значение");
                }
            }
        }
        internal string Symbolism
        {
            get { return symbolism; }
            set
            {
                try
                {
                    if (value == null)
                        throw new ArgumentNullException();
                    symbolism = value;
                }
                catch
                {
                    Console.WriteLine("Пустное значение");
                }
            }
        }

        public State(string name, string currency, string symbolism)
        {
            Name = name;
            Currency = currency;
            Symbolism = symbolism;
        }

        public State() { }

        public abstract string ToString();
    }
}
