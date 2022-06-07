using System;
using System.IO;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string way = @"D:\study\3 курс\C#\labs\lab7\lab7\file.txt";
            string text = File.ReadAllText(way);
            char[] delitel = { '!', '?', '.' };
            string[] newtext = text.Split(delitel);
            Console.Write("Введите слово для поиска: ");
            string word = Console.ReadLine();
            bool isSentense = false;
            for(int i = 0; i < newtext.Length; i++)
            {
                if (newtext[i].IndexOf(word)>=0)
                {
                    isSentense = true;
                    Console.WriteLine(newtext[i]);
                }
            }
            if(!isSentense)
                Console.WriteLine("Предложения не найдены..");
        }
    }
}
