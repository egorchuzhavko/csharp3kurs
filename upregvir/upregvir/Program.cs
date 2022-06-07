using System;
using System.Text.RegularExpressions;
using System.IO;

namespace upregvir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ОБЩЕЕ ЗАДАНИЕ 1");
            Regex rr = new Regex(@"\b[A-Z](\w*\s+){1,10}?[.!?]");
            Console.WriteLine("Введите строку: ");//A !
            string stroka = Console.ReadLine();
            MatchCollection matches = rr.Matches(stroka);
            if (matches.Count > 0)
                foreach(Match item in matches)
                    Console.WriteLine(item.Value);
            else
                Console.WriteLine("Не подходит строка");


            Console.WriteLine("\n\nОБЩЕЕ ЗАДАНИЕ 2\n");
            Regex r2 = new Regex(@"(AB|BM|HB|KH|MP|MC|KB|PP|ST|DT)\d{7}$");
            Console.WriteLine("Введите номер паспорта: ");
            string stroka2 = Console.ReadLine();
            MatchCollection matches2 = r2.Matches(stroka2);
            if (matches2.Count > 0)
                Console.WriteLine("Подходит");
            else
                Console.WriteLine("Не подходит");
                
            Console.WriteLine("\n\nВаринт 22 задание 1\n");
            string stroka221 = "Всем привет <p>Привет?</p> <i>нет</i> <p>Привет!</p>";
            foreach (Match m in Regex.Matches(stroka221, @"<p>.*?</p>"))
                Console.WriteLine(m);

            Console.WriteLine("\n\nВаринт 22 задание 2\n");
            string strk = "Один, два, три, one, один, one,two,three one two three, one three two, one, three, two, one, two, three";
            Regex reg = new Regex(@"\b((one, )+two, three){1,}\b");
            MatchCollection matchess = reg.Matches(strk);
            if (matchess.Count > 0)
                foreach(Match match in matchess)
                    Console.WriteLine(match.Value);
            else
                Console.WriteLine("Совпадений не найдено");

            Console.WriteLine("\n\nВаринт 22 задание 3\n");
            int count = 0;
            DateTime fD = new DateTime(1800, 1, 1);
            DateTime eD = new DateTime(2100, 1, 1);
            Regex r = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](18|20)\d\d");
            StreamReader f = new StreamReader("D:\\study\\3 курс\\C#\\labs\\upregvir\\upregvir\\file.txt");
            string fData = f.ReadToEnd();
            string[] fileData = fData.Split('\n');
            foreach (string str in fileData)
                if (r.IsMatch(str))
                {
                    DateTime dateToCheck = DateTime.Parse(r.Match(str).ToString());
                    if (dateToCheck >= fD && dateToCheck < eD) 
                        count++;
                }
            Console.WriteLine($"Кол-во строк = {count}");
        }
    }
}
