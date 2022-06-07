using System;
using VichInterval;

namespace praktosoop
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeInterval first = TimeInterval.MMin(30);
            TimeInterval second = TimeInterval.TTick(30);
            Console.WriteLine(first.ToString()+"\n");
            Console.WriteLine(second.ToString()+"\n");
            TimeInterval third = first.Addiction(second);
            Console.WriteLine("Сложение 1 на 2\n" + third.ToString() + "\n");
            third = second.Substraction(first);
            Console.WriteLine("Вычитание 2 на 1\n" + third.ToString() + "\n");
        }
    }
}
