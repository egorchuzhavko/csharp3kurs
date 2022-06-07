using System;

namespace lab3
{
    class Program
    {
        static double fun(double x, double eps, ref int i_count)
        {
            double y = 1;
            double r = 0;
            i_count = 1;
            do
            {
                r = ((Math.Pow(-1, i_count) * (Math.Pow(x, i_count))) / (Factorial(i_count++)));
                y += r;
            } while (Math.Abs(r) > eps);
            return y;
        }
        static public double Factorial(int n)
        {
            double res = 1;
            for (int i = n; i > 1; i--)
                res *= i;
            return res;
        }

        static int Main(string[] args)
        {
            int p;
            double x, y, xk, h;
            double a, b, c;
            const double r = 2;
            do
            {
                Console.Write("Введите номер задания: ");
                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        Console.Write("\nВведите x нач: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nВведите x кон: ");
                        xk = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nВведите шаг: ");
                        h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("X=\tY=");
                        for (; x <= xk; x += h)
                        {
                            if (x <= -8)
                            {
                                Console.WriteLine($"{x}\t-3.00");
                            }
                            else if (x > -8 & x <= -3)
                            {
                                Console.WriteLine(x + "\t" + Math.Round((3.0 / 5.0 * (x + 8) - 3), 2));
                            }
                            else if (x > -3 & x <= 3)
                            {
                                Console.WriteLine(x + "\t" + Math.Round((-Math.Sqrt(9 - Math.Pow(x, 2))), 2));
                            }
                            else if (x > 3 & x <= 5)
                            {
                                Console.WriteLine(x + "\t" + Math.Round((x - 3), 2));
                            }
                            else
                            {
                                Console.WriteLine($"{x}\t3.00");
                            }
                        }
                        break;
                    case 2:
                        Random rand = new Random();
                        for (int i = 0; i < 10; i++)
                        {
                            x = -r+2*r * rand.NextDouble();
                            y = -r + 2 *r * rand.NextDouble();
                            Console.WriteLine($"x[{i}]={x}");
                            Console.WriteLine($"y[{i}]={y}");
                            a = (0 - x) * (0 - 0) - (2 - 0) * (0 - y);
                            b = (2 - x) * (-2 - 0) - (1 - 2) * (0 - y);
                            c = (1 - x) * (0 + 2) - (0 - 1) * (-2 - y);
                            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2) && x <= 0 && y >= 0) || (a > 0 && b > 0 && c > 0)
                            || (a < 0 && b < 0 && c < 0) || a == 0 || b == 0 || c == 0)
                            {
                                Console.WriteLine("Попадание\n");
                            }
                            else
                            {
                                Console.WriteLine("Не попадание\n");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Введите x начальное: ");
                        double xNach = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите x конечное: ");
                        double xKonech = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите шаг: ");
                        double dx = Convert.ToDouble(Console.ReadLine());
                        int i_count = 1;
                        Console.Write("Введите eps:");
                        double eps = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"x\ty\te^(-x)\tk");
                        Console.WriteLine();
                        for (double i = xNach; i <= xKonech; i += dx)
                        {
                            Console.WriteLine($"{i,6:f1} | {fun(i, eps, ref i_count),20:f15} | {Math.Exp(-i),20:f15} | {i_count,6}");
                        }
                        break;
                    case 0:
                        return 0;
                    default:
                        Console.WriteLine("Вы ввели неверный номер задания!\n");
                        break;
                }
            } while (p != 0);
            return 0;
        }
    }
}
