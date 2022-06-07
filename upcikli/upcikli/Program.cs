using System;

namespace upcikli
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            do
            {
                int n, chislo = 10, chetchik = 0, zdabitak = 1, h = 0, a, proiz = 1, summa = 0;
                double nn, x, y = 0, aa;
                Console.Write("Введите номер задания: ");
                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        Console.Write("Введите число n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            if (chislo % 5 == 0)
                            {
                                chetchik++;
                                zdabitak *= chislo;
                            }
                            chislo++;
                        } while (chetchik != n | chislo < 99);
                        Console.WriteLine($"Произведение чисел, кратных 5 = {zdabitak}");
                        break;
                    case 2:
                        Console.WriteLine("x\ty\n");
                        while (h <= 360)
                        {
                            Console.WriteLine(h + "\t" + (Math.Cos(h) + Math.Sin(h)));
                            h += 15;
                        }
                        break;
                    case 3:
                        Console.Write("Введите число n: ");
                        nn = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите число x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        for (int i = 1; i <= nn; i++)
                        {
                            y += Math.Pow(x - 1, i) * (Math.Pow(x - 1, i) / i);
                        }
                        Console.WriteLine("y = " + y);
                        break;
                    case 4:
                        Console.Write("Введите число n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        double z = n;
                        for(double i = n ; i >= 0; i--)
                        {
                            y = (2 * i + 1) + 1 / z;
                            z = y;
                        }
                        Console.WriteLine("y = " + z);
                        break;
                    case 5:
                        Console.Write("Введите число a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (a >= 0)
                        {
                            for(int i = 2; i < 16; i += 2)
                            {
                                summa += (i + 1) / (i + 2);
                            }
                            Console.WriteLine("Сумма = " + summa);
                        }
                        else
                        {
                            for(int i = 3; i < 12; i += 3)
                            {
                                proiz *= (i + 1);
                            }
                            Console.WriteLine("Произведение = " + proiz);
                        }
                        break;
                    case 6:
                        Console.Write("Введите a: ");
                        aa = Convert.ToDouble(Console.ReadLine());
                        double aaa = aa;
                        for(int i = 0; aa <= (aaa * 2.5); i++)
                        {
                            aa = aa + aa * 0.4;
                            chetchik = i;
                        }
                        Console.WriteLine($"Гриб вырастет в 2.5 раза за {chetchik} дней");
                        break;
                }
            } while (p != 0);
        }
    }
}
