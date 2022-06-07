using System;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x;
            Console.Write("Задание 2\nВведите а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("В футах a = " + a / 0.40951 + "\n");


            Console.Write("Задание 3\nВведите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            double b = x * (Math.Pow(Math.Pow(x, 2.0) + Math.Pow(a, 2.0), 3.0)) +
                Math.Log((Math.Pow(x, 2.0) + Math.Sqrt(Math.Pow(x, 2.0) + 1.0)), 5.0);
            Console.WriteLine("b = " + b + "\n");


            double x1, x2, y1, y2;
            Console.Write("Задание 4\nВведите x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
            Console.WriteLine("S = " + d * d / 2.0 + "\n");


            Console.Write("Задание 5\nВведите x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            double r = x1;
            Console.WriteLine("S = " + (2 * Math.PI * r * (r + y2)));
        }
    }
}
