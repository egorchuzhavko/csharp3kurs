using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            double x, y, r, a, b, c;
            do
            {
                Console.Write("Введите номер задания: ");
                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        Console.Write("\nВведите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x <= -8)
                        {
                            Console.WriteLine("y = -3\n");
                        }
                        else if (x > -8 & x <= -3)
                        {
                            Console.WriteLine("y = " + (3.0 / 5.0 * (x + 8) - 3) + '\n');
                        }
                        else if (x > -3 & x <= 3)
                        {
                            Console.WriteLine("y = " + (-Math.Sqrt(9 - Math.Pow(x, 2))) + '\n');
                        }
                        else if (x > 3 & x <= 5)
                        {
                            Console.WriteLine("y = " + (x - 3) + '\n');
                        }
                        else
                        {
                            Console.WriteLine("y = 3\n");
                        }
                        break;
                    case 2:
                        Console.Write("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите r: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        a = (0 - x) * (0 - 0) - (r - 0) * (0 - y);
                        b = (r - x) * (-r - 0) - (r / 2 - r) * (0 - y);
                        c = (r / 2 - x) * (0 + r) - (0 - r / 2) * (-r - y);
                        if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2) && x <= 0 && y >= 0)|| (a > 0 && b > 0 && c > 0) 
                            || (a < 0 && b < 0 && c < 0) || a == 0 || b == 0 || c == 0)
                        {
                            Console.WriteLine("Попадание\n");
                        }
                        else
                        {
                            Console.WriteLine("Не попадание\n");
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверный номер задания!\n");
                        break;
                }
            } while (p != 0);
        }
    }
}
