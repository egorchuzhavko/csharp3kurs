using System;

namespace operatoriuslovia
{
    class Program
    {
        static int Main(string[] args)
        {
            double p = 0, x = 0, y = 0, z = 0, a = 0, b = 0;
            do {
                Console.Write("Введите номер задания (1-5 задания; 0 - выход из программы): ");
                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 0:
                        return 0;

                    case 1:
                        Console.Write("\nВведите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x == 0)
                        {
                            Console.WriteLine("y = 0\n");
                        }
                        else if (x > 0)
                        {
                            Console.WriteLine("y = " + Math.Pow(x, 2) + '\n');
                        }
                        else
                        {
                            Console.WriteLine("y = " + Math.Pow(x, 4) + '\n');
                        }
                        break;

                    case 2:
                        Console.Write("\nВведите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nВведите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nВведите z: ");
                        z = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("r = " + Math.Max(Math.Min(x, y), z) + '\n');
                        break;

                    case 3:
                        Console.Write("\nВведите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nВведите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine((2 * y < x & Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) ? "Принадлежит\n" : "Не принадлежит\n");
                        break;

                    case 4:
                        Console.Write("\nВведите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x <= 0)
                        {
                            Console.WriteLine("y = " + (x + 1) + '\n');
                        }
                        else if (x <= 1)
                        {
                            Console.WriteLine("y = " + (1 - Math.Pow(x, 3)) + '\n');
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели x в неверном диапазоне..\n");
                        }
                        break;

                    case 5:
                        Console.Write("\nВведите a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nВведите b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        if (b < a)
                        {
                            Console.WriteLine("Нет решений!");
                        }
                        else if (a < b)
                        {
                            Console.WriteLine($"X принадлежит ({a};{b})\n");
                        }
                        else
                        {
                            Console.WriteLine("Х принадлежит (-бесконечность;{b})U({a};+бесконечность)\n");
                        }
                        break;

                    case 6:
                        int i;
                        Console.Write("\nВведите i: ");
                        i = Convert.ToInt32(Console.ReadLine());
                        if (1 <= i & i <= 100)
                        {
                            Console.WriteLine("m = " + Math.Pow(i, 2) + Math.Sqrt(i) + '\n');
                        }
                        else if (101 <= i & i <= 200)
                        {
                            Console.WriteLine("m = " + (2 * Math.Pow(i, 2) - i) + '\n');
                        }
                        else
                        {
                            Console.WriteLine("m = 0\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Вы не ввели номер задания!");
                        break;
                }
            } while (p != 0);
            return 0;
        }
    }
}
