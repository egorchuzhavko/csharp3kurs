using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] mas1 = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    mas1[i, j] = random.Next(0, 10);
                    Console.Write(mas1[i, j] + " ");
                }
                Console.WriteLine();
            }
            bool isZero = false;
            int count = 0;
            for(int j = 0; j < m; j++)
            {
                isZero = false;
                for(int i = 0; i < n; i++)
                {
                    if (mas1[i, j] == 0)
                    {
                        isZero = true;
                        break;
                    }
                }
                if (isZero == false)
                    count++;
            }
            Console.WriteLine();
            Console.WriteLine($"Количество столбцов без нулевых элементов = {count}");
            Console.WriteLine();
            int[] mas2 = new int[n];
            int sumtemp = 0;
            for(int i = 0; i < n; i++)
            {
                sumtemp = 0;
                for(int j = 0; j < m; j++)
                {
                    if (mas1[i, j] % 2 == 0 & mas1[i, j] > 0)
                        sumtemp += mas1[i, j];
                }
                mas2[i] = sumtemp;
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(mas2[i] + " - " + i);
            }
            for (int k = n - 1; k > 0; k--)
            {
                for (int i = 0; i < k; i++)
                {
                    if (mas2[i] > mas2[i + 1])
                    {
                        (mas2[i], mas2[i + 1]) = (mas2[i + 1], mas2[i]);
                        for(int j = 0; j < m; j++)
                        {
                            (mas1[i, j], mas1[i+1, j]) = (mas1[i+1, j], mas1[i, j]);
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
