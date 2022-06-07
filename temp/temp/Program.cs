using temp;
using System.Xml;
using System.Xml.Linq;

List<Zachetka> zachetkas = new List<Zachetka>();

var ses1 = new Sessia("КПиЯП", 9);
var ses2 = new Sessia("АУДО", 8);
var ses3 = new Sessia("ТестированиеПо", 7);
var ses6 = new Sessia("ТестированиеПо", 8);
var ses4 = new Sessia("ФизКультура", 6);
var ses5 = new Sessia("Англ Яз", 3);

var zac1 = new Zachetka(3, 2, "Т-993", "Парфянович Александр Сергеевич", 87654321, ses1);
var zac2 = new Zachetka(1, 2, "Т-992", "Быковский Матвей Максимович", 45368273, ses2);
var zac3 = new Zachetka(3, 2, "Т-992", "Чужавко Егор Андреевич", 51530041, ses3);
var zac4 = new Zachetka(3, 2, "Т-992", "Раткевич Денис Юрьевич", 56738139, ses6);
var zac5 = new Zachetka(3, 2, "Т-992", "Спарф Александр Сергеевич", 67382746, ses4);

zachetkas.Add(zac1);
zachetkas.Add(zac2);
zachetkas.Add(zac3);
zachetkas.Add(zac4);
zachetkas.Add(zac5);

XDocument document = new XDocument
(
    new XElement("Zachetkas",
    from zachetka in zachetkas
    select new XElement("Zachetka",
           new XElement("Kurs", zachetka.Kurs),
           new XElement("Semestr", zachetka.Semestr),
           new XElement("GroupNumber", zachetka.NumberGroup),
           new XElement("FIO", zachetka.Fio),
           new XElement("ZachetkaNumber", zachetka.NumberZacBook),
           from sessia in zachetka.Sessias
           select new XElement("Sesias",
                  new XAttribute("SesiaName", sessia.Name),
                  new XAttribute("SesiaMark", sessia.Mark)

))));
document.Save(@"XmlTest.xml");

Console.WriteLine("Вывод из XML: \n\n");
var doc = new XmlDocument();
doc.Load(@"XmlTest.xml");
var root = doc.DocumentElement;
PrintItem(root);
Console.WriteLine();
Console.WriteLine();


Console.Write("Выберите пункт меню (1-5)\n1-сортировка\n2-одинаковый номер группы\n3-оценка ниже заданной\n4-средняя оценка\n5-группировка: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while (n < 1 || n > 5)
{
    Console.WriteLine("Ошибка!!!");
    Console.Write("Выберите пункт меню (1-5): ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

switch (n)
{
    case 1:
        Console.WriteLine("Сортировка по двум параметрам: ");
        XDocument xelement1 = XDocument.Load("XmlTest.xml");
        var res = xelement1.Descendants("Zachetka")
            .OrderBy(x => x.Element("Kurs").Value)
            .ThenBy(x => x.Element("GroupNumber").Value)
            .Select(x => x.Element("FIO").Value + " " + x.Element("Kurs").Value + " " + x.Element("GroupNumber").Value);
        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
        break;
    case 2:
        Console.Write("Введите номер группы: ");
        string nb = Convert.ToString(Console.ReadLine());

        foreach (var item2 in zachetkas)
        {
            if (nb == item2.NumberGroup)
            {
                Console.WriteLine($"Номер зачетки студентов с одинаковой группой: {item2.NumberZacBook}");
            }
        }
        break;
    case 3:
        List<string> list33 = new List<string>();
        foreach (var element3 in zachetkas)
        {
            var fio = element3.Fio;
            bool flag = false;
            foreach (var element33 in element3.Sessias)
            {
                if (!flag)
                {
                    var mark = element33.Mark;
                    if (mark != null)
                    {
                        if (mark < 4)
                        {
                            Console.WriteLine($"ФИО студента с оценкой ниже 4: {element3.Fio}");
                            flag = true;
                        }
                    }
                }
            }
        }
        break;
    case 4:
        List<string> list4 = new List<string>();
        List<int> list5 = new List<int>();
        foreach (var element4 in zachetkas)
        {
            foreach(var element5 in element4.Sessias)
            {
                list5.Add(element5.Mark);
                list4.Add(element5.Name);
            }
        }
        List<string> temppr = new List<string>();
        for (int i = 0; i < list4.Count; i++)
        {
            int countofmark = 1;
            int tempsum = list5[i];
            bool flag = false;
            for(int j =i+1;j< list4.Count; j++)
            {
                if (list4[i] == list4[j])
                {
                    countofmark++;
                    tempsum += list5[j];
                }
            }
            foreach(string j in temppr)
            {
                if (j == list4[i])
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine(list4[i] + " " + (double)tempsum / countofmark);
                temppr.Add(list4[i]);
            }
        }
        break;
    case 5:
        Console.WriteLine(5);
        break;
    default:
        Console.WriteLine("default");
        break;
}

static void PrintItem(XmlElement item, int indent = 0)
{
    Console.Write($"{new string('\t', indent)}{item.LocalName} ");
    foreach (XmlAttribute attr in item.Attributes)
    {
        Console.Write($"[{attr.InnerText}]");
    }
    foreach (var child in item.ChildNodes)
    {
        if (child is XmlElement node)
        {
            Console.WriteLine();
            PrintItem(node, indent + 1);
        }

        if (child is XmlText text)
        {
            Console.Write($"- {text.InnerText}");
        }
    }
}