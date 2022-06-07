using System;

namespace massivi
{
    class dvumernie
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int p;
            do
            {
                Console.Write("Введите номер задания: ");
                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        int[,] mas = new int[10, 10];
                        int ch = 10, ch2 = 10;
                        for (int i = 0; i < 10; i++, ch--)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (j == 0)
                                {
                                    ch2 = ch;
                                }
                                if (ch2 <= 0)
                                {
                                    mas[i, j] = 0;
                                }
                                else
                                {
                                    mas[i, j] = ch2;
                                }
                                ch2--;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        int[,] mas2 = new int[5, 5];
                        for(int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                mas2[i, j] = random.Next(0, 10);
                                Console.Write(mas2[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        int summa = 0;
                        for(int i = 0; i < 5; i++)
                        {
                            for(int j = 0; j < 5; j++)
                            {
                                if (!(i == j) & (mas2[i, j] < mas2[i, i]))
                                    summa += mas2[i, j];
                            }
                        }
                        Console.WriteLine("Сумма элементов меньших элементам гл. диагонали = " + summa);
                        break;

                    case 3:
                        int[,] mas3 = new int[3, 4];
                        for (int i = 0; i < 3; i++)
                        {
                            for(int j = 0; j < 4; j++)
                            {
                                mas3[i, j] = random.Next(-3, 3);
                                Console.Write(mas3[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        int maks = Math.Abs(mas3[0, 0]);
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (maks < Math.Abs(mas3[i, j]))
                                    maks = Math.Abs(mas3[i, j]);
                            }
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                mas3[i, j] *= maks;
                                Console.Write(mas3[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        Console.Write("Введите n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int[,] mas4 = new int[n, n];
                        for(int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                mas4[i, j] = random.Next(1, 10);
                                Console.Write(mas4[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        int[] A = new int[n];
                        for (int j = 0; j < n; j++)
                        {
                            int fl = 0;
                            for (int i = 0; i < n - 1; i++)
                            {
                                if (mas4[i,j] <= mas4[i + 1,j])
                                    fl = 1;
                            }
                            if (fl == 1)
                                A[j] = 0;
                            else
                                A[j] = 1;
                        }
                        for(int i = 0; i < n; i++)
                        {
                            Console.Write(A[i] + " "); 
                        }
                        break;

                    case 5:
                        int[,] mas5 = new int[3, 4];
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                mas5[i, j] = random.Next(0, 9);
                                Console.Write(mas5[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        for (int j = 0; j < 3; j++)
                        {
                            for (int y = 0; y < 3 - j; y++)
                            {
                                if (mas5[2, y] < mas5[2, y + 1])
                                {
                                    for (int k = 0; k < 3; k++)
                                    {
                                        (mas5[k, y], mas5[k, y + 1]) = (mas5[k, y + 1], mas5[k, y]);
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        for(int i = 0; i < 3; i++)
                        {
                            for(int j = 0; j < 4; j++)
                            {
                                Console.Write(mas5[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        int[,] mas6 = new int[8, 10];
                        for(int i = 0; i < 8; i++)
                        {
                            for(int j = 0; j < 10; j++)
                            {
                                mas6[i, j] = random.Next(1, 10);
                            }
                        }
                        int[,] ocenka = new int[2, 10];
                        int summaceni = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            ocenka[0, i] = i + 1;
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            summaceni = 0;
                            for (int j = 0; j < 8; j++)
                            {
                                summaceni += mas6[j, i];
                            }
                            ocenka[1, i] = summaceni;
                        }
                        for(int i =0;i<=1;i++)
                        {
                            for(int j = 0; j < 10; j++)
                            {
                                Console.Write(ocenka[i, j]+" ");
                            }
                            Console.WriteLine();
                        }
                        for (int q = 0; q < 10; q++)
                        {
                            for (int j = 0; j <= 1; j++)
                            {
                                for (int y = 0; y < 9 - j; y++)
                                {
                                    if (ocenka[1, y] > ocenka[1, y + 1])
                                    {
                                        for (int k = 0; k <= 1; k++)
                                        {
                                            (ocenka[k, y], ocenka[k, y + 1]) = (ocenka[k, y + 1], ocenka[k, y]);
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        for(int i = 0; i < 2; i++)
                        {
                            for(int j = 0; j < 10; j++)
                            {
                                Console.Write(ocenka[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                Console.Write($"Продукт №{ocenka[j,i]} имеет оценку {ocenka[j+1, i]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            } while (p != 0);
        }
    }
}
