using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            int i;
            Console.Write(" Введите 1 - если перевести в радианы, 2 - если оставить в градусах: ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                a = a * Math.PI / 180.0;
            }
            double z1 = 2.0 * Math.Pow(Math.Sin(3.0 * Math.PI - 2.0 * a), 2.0) * Math.Pow(Math.Cos(5.0 * Math.PI + 2.0 * a), 2.0);
            double z2 = (1.0 / 4) - (1.0 / 4) * Math.Sin((5.0 / 2) * Math.PI - 8.0 * a);
            Console.WriteLine($"Задание 1.0:\tz1 = {z1}\tz2 = {z2}\n");

            z1 = (2.0 * Math.Tan(a / 2.0)) / (1.0 + Math.Pow(Math.Tan(a / 2.0), 2.0));
            z2 = Math.Tan(a) / (Math.Abs(Math.Sqrt(1.0 + Math.Pow(Math.Tan(a), 2.0))));
            Console.WriteLine($"Задание 1.1:\tz1 = {z1}\tz2 = {z2}\n");
        }
    }
}
