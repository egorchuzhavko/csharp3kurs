using System;
using System.Collections.Generic;
using System.Text;

List<Serial> list = new List<Serial>();
list.Add(new Serial("Сериал 1", 2015, 11));
list.Add(new Serial("Сериал 2", 2011, 13));
list.Add(new Serial("Сериал 3", 2004, 4));
list.Add(new Serial("Сериал 4", 2002, 7));
list.Add(new Serial("Сериал 5", 2003, 15));

foreach (Serial serial in list) Console.WriteLine(serial);
Console.WriteLine("\n\n");
Serial.SeriesWithCountOfSeriesMore12(list);
Console.WriteLine("\n\nСортировка по году: ");
list = Serial.SortByYear(list);
foreach (Serial serial in list) Console.WriteLine(serial);


public class Serial : Exception
{
    string name;
    int year;
    int series;
    public Serial(string name, int year, int series)
    {
        this.name = name;
        this.year = year;
        this.series = series;
    }

    public static List<Serial> SortByYear(List<Serial> list)
    {
        return list.OrderBy(x => x.year).ToList();
    }

    public string Name
    {
        set { name = value; }
        get { return name; }
    }
    public int Year
    {
        set
        {
            if (value > 1920 && value < 2021)
            {
                year = value;
            }
            else
            {
                throw new Exception("Ошибка, введите заного");
            }
        }
        get { return year; }
    }
    public int Series
    {
        set
        {
            if (value > 2)
            {
                year = value;
            }
            else
            {
                throw new Exception("Ошибка, введите заного");
            }
        }

        get { return series; }

    }
    public bool IsExist()
    {
        if (year > 1920 && year < 2021 && series > 2)
        {
            return true;
        }
        return false;
    }
    public static void SeriesWithCountOfSeriesMore12(List<Serial> list)
    {
        List<Serial> list1 = list.Where(x => x.Series > 12).ToList();
        if (list1.Count > 0)
        {
            Console.WriteLine("Сериалы, где больше 12 серий:");
            foreach (var x in list1) Console.WriteLine(x);
        }
        else
            Console.WriteLine("Сериалов, где больше 12 серий нет");
    }
    public override string ToString()
    {
        return $"{name}, {year}, {series}";
    }
}