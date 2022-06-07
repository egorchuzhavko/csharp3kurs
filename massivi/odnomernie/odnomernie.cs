using System;

namespace odnomernie
{
    class odnomernie
    {
        static void Main(string[] args)
        {
            int p;
            Random random = new Random();
            do
            {
                Console.Write("Введите номер задания: ");
                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        int[] mas1 = new int[10];
                        int proizv1 = 1;
                        for(int i = 0; i < 10; i++)
                        {
                            mas1[i] = random.Next(1, 10);
                            Console.Write(mas1[i] + " ");
                            if (i % 2 == 0)
                                proizv1 *= mas1[i];
                        }
                        Console.WriteLine("Произведение = " + proizv1);
                        break;

                    case 2:
                        int[] mas2 = new int[10];
                        for(int i = 0; i < 10; i++)
                        {
                            mas2[i] = random.Next(1, 1000);
                        }
                        for(int i = 0; i < 10; i++)
                        {
                            for(int j = 0; j < 10; j++)
                            {
                                if (mas2[i] == mas2[j])
                                {
                                    mas2[i] = random.Next(1, 1000);
                                }
                            }
                        }
                        int IndexMax = 0;
                        int ZnMax = mas2[0];
                        for(int i = 0; i < 10; i++)
                        {
                            if (ZnMax < mas2[i])
                            {
                                ZnMax = mas2[i];
                                IndexMax = i;
                            }
                        }
                        int kolvozn = 0;
                        for(int i = IndexMax; i < 10; i++)
                        {
                            kolvozn++;
                        }
                        Console.WriteLine("кол-во элементов после макс. = " + kolvozn);
                        break;

                    case 3:
                        string[] mas3 = new string[8];
                        for(int i = 0; i < 8; i++)
                        {
                            Console.Write($"Введите {i} элемент массива: ");
                            mas3[i] = Console.ReadLine();
                        }
                        int pos_min;
                        string temp;

                        for (int i = 0; i < mas3.Length - 1; i++)
                        {
                            pos_min = i;
                            for (int j = i + 1; j < mas3.Length; j++)
                            {
                                if (mas3[j].CompareTo(mas3[pos_min]) < 0)
                                {
                                    pos_min = j;
                                }
                            }
                            if (pos_min != i)
                            {
                                temp = mas3[i];
                                mas3[i] = mas3[pos_min];
                                mas3[pos_min] = temp;
                            }
                        }
                        for(int i = 0; i < 8; i++)
                        {
                            Console.Write(mas3[i] + " ");
                            if (i == 2)
                            {
                                Console.WriteLine("\n");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        int[] mas4 = new int[11];
                        int ch = 1;
                        for(int i = 0; i < 11; i++, ch++)
                        {
                            mas4[i] = ch;
                            Console.Write(mas4[i] + " ");
                        }
                        Console.WriteLine();
                        bool checkpoint = false;
                        for(int i = 4; i < 11; i++)
                        {
                            if (i == 10)
                            {
                                Console.Write(mas4[i] + " ");
                                i = 0;
                                checkpoint = !checkpoint;
                            }
                            Console.Write(mas4[i] + " ");
                            if (i == 3 & checkpoint)
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        int[] mas5 = new int[9];
                        for(int i = 0; i < 9; i++)
                        {
                            mas5[i] = random.Next(1, 10);
                        }
                        for(int i = 0; i < 9; i++)
                        {
                            if (i == 0)
                            {
                                if (mas5[8] % 2 == 0 & mas5[1] % 2 == 0)
                                    (mas5[8], mas5[1]) = (mas5[1], mas5[8]);
                            }
                            else if (i == 8)
                            {
                                if (mas5[7] % 2 == 0 & mas5[0] % 2 == 0)
                                    (mas5[7], mas5[0]) = (mas5[0], mas5[7]);
                            }
                            else
                            {
                                if (mas5[i - 1] % 2 == 0 & mas5[i + 1] % 2 == 0)
                                    (mas5[i - 1], mas5[i + 1]) = (mas5[i + 1], mas5[i - 1]);
                            }
                        }
                        for (int i = 0; i < mas5.Length; i++)
                        {
                            Console.Write(mas5[i] + " ");
                        }
                        break;
                    case 6:
                        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        Console.Write("Введите n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int[] b = new int[n];
                        int lengtha = a.Length;
                        for(int i = 0; i < n; i++)
                        {
                            b[i] = random.Next(1, 100);
                            Console.Write(b[i] + " ");
                        }
                        string chisla = "1.2.3.4.5.6.7.8.9.10";
                        for(int i = 0; i < n; i++)
                        {
                            string tmp = Convert.ToString(b[i]);
                            if (chisla.IndexOf(tmp) < 0)
                                chisla += "." + tmp;
                        }
                        string[] massiv = chisla.Split(".");
                        for (int i = 0; i < massiv.Length; i++)
                            Console.Write(massiv[i] + " ");
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.Write("Введите размерность массива: ");
                        int razmernost = Convert.ToInt32(Console.ReadLine());
                        int[] mas7 = new int[razmernost];
                        for(int i = 0; i < mas7.Length; i++)
                        {
                            mas7[i] = random.Next(1, 30);
                            Console.Write(mas7[i] + " ");
                        }
                        Console.WriteLine();
                        bool isExists = false;
                        for(int i = 0; i < 30; i++)
                        {
                            isExists = false;
                            for (int j = 0; j < mas7.Length; j++)
                            {
                                if (i == mas7[j])
                                {
                                    isExists = true;
                                    break;
                                }
                            }
                            if (!isExists)
                                Console.WriteLine("Никто не дал ответ на вопрос " + i);
                        }
                        break;
                }
            } while (p != 0);
        }
    }
}
