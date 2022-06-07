using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int n = 10;
            int[] mas = new int[10];
            int sum = 0, proizvedenie = 1;
            int MinIndex = 0, MinZn = Math.Abs(mas[0]), MaxIndex = 0, MaxZn = Math.Abs(mas[0]);
            Console.WriteLine("Массив:");
            for(int i = 0; i < n; i++)
            {
                mas[i] = random.Next(-10, 10);
                Console.Write(mas[i] + " ");
                sum += mas[i];
            }
            for(int i = 0; i < n; i++)
            {
                if (Math.Abs(mas[i]) > MaxZn)
                {
                    MaxZn = Math.Abs(mas[i]);
                    MaxIndex = i;
                }
                if (Math.Abs(mas[i]) < MinZn)
                {
                    MinZn = Math.Abs(mas[i]);
                    MinIndex = i;
                }
            }
            if(MinIndex<MaxIndex)
            {
                for(int i = MinIndex;i<MaxIndex;i++)
                {
                    proizvedenie *= mas[i];
                }
            }
            else
            {
                for (int i = MaxIndex; i < MinIndex; i++)
                {
                    proizvedenie *= mas[i];
                }
            }
            Console.WriteLine("\nПроизведение между максимальным и минимальными значениями = " + proizvedenie);
            for (int j = 0; j < mas.Length - 1; j++)
            {
                for (int y = 0; y < mas.Length - 1 - j; y++)
                {
                    if (mas[y] < mas[y + 1])
                    {
                        int temp = mas[y];
                        mas[y] = mas[y + 1];
                        mas[y + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}
