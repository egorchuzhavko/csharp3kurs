using System;

namespace magicsquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0)
            {
                int[,] mas1_1 = new int[n, n];
                int q = n / 2 - 1;
                int o = n / 2;
                for (int num = 1; num <= n * n;)
                {
                    if (o == n)
                        o = 0;
                    if (q == -1)
                        q = n - 1;
                    if (mas1_1[q, o] == 0)
                        mas1_1[q, o] = num;
                    else
                    {
                        q--;
                        o--;
                        if (o == -1)
                            o = n - 1;
                        mas1_1[q, o] = num;
                    }
                    q--;
                    o++;
                    if (q == 0 && o == 1)
                    {
                        q--;
                        o--;
                    }
                    num++;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{mas1_1[i, j],3} ");
                    }
                    Console.WriteLine();
                }
            }
            else if (n % 4 == 0)
            {
                int[,] mas1 = new int[n, n];
                bool isNormal = false;
                int number = 0;
                for (int i = 0; i < n / 2; i++)
                {
                    isNormal = !isNormal;
                    if (isNormal)
                        number = 1;
                    else
                        number = n;
                    for (int j = 0; j < n; j++)
                    {
                        mas1[i, j] = number;
                        if (isNormal)
                            number++;
                        else
                            number--;
                    }
                }
                for (int i = n / 2; i < n; i++)
                {
                    isNormal = !isNormal;
                    if (isNormal)
                        number = n;
                    else
                        number = 1;
                    for (int j = 0; j < n; j++)
                    {
                        mas1[i, j] = number;
                        if (isNormal)
                            number--;
                        else
                            number++;
                    }
                }
                Console.WriteLine("Первый массив: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{mas1[i, j],3} ");
                    }
                    Console.WriteLine();
                }



                int[,] mas2 = new int[n, n];
                isNormal = false;
                for (int i = 0; i < n / 2; i++)
                {
                    isNormal = !isNormal;
                    if (isNormal)
                        number = 0;
                    else
                        number = n - 1;
                    for (int j = 0; j < n; j++)
                    {
                        mas2[j, i] = number * n;
                        if (isNormal)
                            number++;
                        else
                            number--;
                    }
                }
                for (int i = n / 2; i < n; i++)
                {
                    isNormal = !isNormal;
                    if (isNormal)
                        number = n - 1;
                    else
                        number = 0;
                    for (int j = 0; j < n; j++)
                    {
                        mas2[j, i] = number * n;
                        if (isNormal)
                            number--;
                        else
                            number++;
                    }
                }
                Console.WriteLine("Второй массив: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{mas2[i, j],3} ");
                    }
                    Console.WriteLine();
                }


                int[,] mas3 = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas3[i, j] = mas1[i, j] + mas2[i, j];
                    }
                }
                Console.WriteLine("Итоговый массив: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{mas3[i, j],3} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
