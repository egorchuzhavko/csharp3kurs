using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x;
            Console.Write("Введите а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            double F = Math.Exp(-2 * Math.PI * a * (Math.Sqrt(Math.Pow(x, 2.0) + 1.2))) +
                13.0 * Math.Pow(x, 3 / 2.0) + Math.Pow(x * a, 1 / a) + Math.Log(Math.Abs(Math.Tan(x / 2.0)));
           // double F = (a + x + Math.Pow(Math.Sin(a), 2.0)) * Math.Cos(Math.Pow(x, -1)) + (a / (Math.Sin(a) + x * Math.Cos(Math.Pow(x, -2.0)))) - Math.Exp(a - x);
            string str = String.Format("{0:e4}", F);
            Console.WriteLine("F = " + str);
        }
    }
}
