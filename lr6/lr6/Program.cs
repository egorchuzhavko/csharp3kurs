using System;
using System.Text.RegularExpressions;

namespace lr6
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "Всем привет, щас время 15:21, а вот ещё время 12:30";
            Console.WriteLine(stroka);
            Console.WriteLine(Data.ChangeDate(stroka, 9));
        }
    }
}
