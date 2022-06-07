using System;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            Console.Write("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("S = " + (4 * ((1.0 / 2) * b * b) + Math.Pow(b, 2)));
        }
    }
}
