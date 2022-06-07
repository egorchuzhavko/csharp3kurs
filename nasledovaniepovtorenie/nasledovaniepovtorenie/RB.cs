using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal sealed class RB : Republic
    {
        private const string president = "Лукашенко";
        private double population;

        public string President
        {
            get { return president; }
        }

        public double Population
        {
            get { return population; }
            set 
            { 
                try {
                    if (value <= 0)
                        throw new ArgumentException();
                    population = value;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Неверное значение");
                }
            }
        }
        public RB(double population) : base("Республика Беларусь", "Белорусский рубль", "Зубр", "Президентская", "Президент")
        {
            Population = population;
        }

        public override string ToString()
        {
            return $"Название: {Name}\nВалюта: {Currency}\nСимволика: {Symbolism}\nВид: {Type}\nПравительство: {Government}\nПрезидент: {President}\nНаселение: {Population} млн.\n";
        }
    }
}
