using xml;
using System.Xml;
using System.Xml.Linq;

List<Discipline> disciplines = new List<Discipline>();
Discipline d1= new Discipline("ОАиП", "Шаляпин", 26, 100, 300, true, "экзамен");
Discipline d2 = new Discipline("Основы права", "Кутузова", 26, 30, 10, false, "зачёт");
Discipline d3 = new Discipline("Основы кроссплатформенного программирования", "Кибисова", 26, 20, 150, false, "экзамен");

disciplines.Add(d1);
disciplines.Add(d2);
disciplines.Add(d3);

int p = 0;
do
{
    Console.Write("1 - Вывод текущих данных из листа\n" +
    "2 - Добавление объектов в лист\n" +
    "3 - Одноимённая сортировка по фамилии преподавателя и кол-ву студентов в группе\n" +
    "4 - Названия дисциплин, имеющих курсовую работу\n" +
    "5 - Фамилия преподавателя с наибольшим количеством экзаменов\n" +
    "6 - Количество практических занятий по всем учебных дисциплинам\n" +
    "7 - Группировка по каждому полю\n" +
    "0 - Выход из меню листа\n" +
    "Пункт меню: ");
    p = Convert.ToInt32(Console.ReadLine());
    switch (p)
    {
        case 0:
            break;
        case 1:
            Console.WriteLine();
            foreach (var line in disciplines)
            {
                Console.WriteLine(line);
                Console.WriteLine("\n" + new string('-', 100) + "\n");
            }
            Console.WriteLine("\n");
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine("Введите дисциплину: ");
            string disc= Console.ReadLine();
            Console.WriteLine("Введите фамилию преподавателя: ");
            string teachname= Console.ReadLine();
            Console.WriteLine("Введите количество людей в группе: ");
            int cvg= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество часов лекций: ");
            int chl= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество часов практики: ");
            int chp= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Есть ли курсовая (1 - да, остальные цифры - нет): ");
            bool kursach = false;
            int zn = Convert.ToInt32((Console.ReadLine()));
            kursach = (zn == 1 ? true : false);
            Console.WriteLine("Итоговый контроль(экзамен/зачёт): ");
            string ik= Console.ReadLine();
            disciplines.Add(new Discipline(disc, teachname, cvg, chl, chp, kursach, ik));
            Console.WriteLine("\n");
            break;
        case 3:
            Console.WriteLine();
            disciplines = disciplines.OrderBy(x => x.CountOfStudentsInGroup).ThenBy(x => x.TeachersSurname).ToList();
            Console.WriteLine("Лист отсортирован\n");
            Console.WriteLine("\n");
            break;
        case 4:
            Console.WriteLine();
            Console.WriteLine("Дисциплины, имеющие курсовую работу:");
            bool ishave = false;
            foreach(var line in disciplines)
            {
                if (line.AvailabilityOfKursovaya)
                {
                    Console.WriteLine(line.NameOfDiscipline);
                    ishave = true;
                }
            }
            if (!ishave) Console.WriteLine("Дисциплин нет");
            Console.WriteLine("\n");
            break;
        case 5:
            Console.WriteLine();
            List<string> teachers = new List<string>();
            foreach(var line in disciplines)
            {
                if (line.TypeOfFinalControl == "экзамен")
                {
                    teachers.Add(line.TeachersSurname);
                }
            }
            int count = 0;
            string teacher = "";
            for (int i = 0; i < teachers.Count; i++)
            {
                int tempp = 0;
                for (int j = 0; j < teachers.Count; j++)
                {
                    if (teachers[i] == teachers[j])
                        tempp++;
                }
                if (tempp > count)
                {
                    teacher = teachers[i];
                    count = tempp;
                }
            }
            Console.WriteLine("Преподаватель с наибольшим количеством экзаменов: " + teacher);
            Console.WriteLine("\n");
            break;
        case 6:
            Console.WriteLine();
            List<string> temppredmeti=new List<string>();
            for (int i = 0; i < disciplines.Count; i++)
            {
                int countofhours = 0;
                for (int j = i; j < disciplines.Count; j++)
                {
                    if (disciplines[i].NameOfDiscipline == disciplines[j].NameOfDiscipline)
                        countofhours += disciplines[i].CountOfHoursForPractice;
                }
                bool check = false;
                foreach(string temp1 in temppredmeti)
                {
                    if (temp1 == disciplines[i].NameOfDiscipline)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                    Console.WriteLine($"Дисциплина {disciplines[i].NameOfDiscipline} с количеством часов: {countofhours}");
                temppredmeti.Add(disciplines[i].NameOfDiscipline);
            }
            Console.WriteLine("\n");
            break;
        case 7:
            Console.WriteLine();
            var dscp = from Discipline in disciplines group Discipline by Discipline.TeachersSurname;
            foreach(var dsc in dscp)
            {
                Console.WriteLine(dsc.Key);
                foreach(var d in dsc)
                {
                    Console.WriteLine(d.NameOfDiscipline);

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            break;
    }
} while (p != 0);

/////////////////
Console.WriteLine("\n\nЗапись в XML\n\n\n");
XDocument xdoc = new XDocument
        (
            new XElement("disciplines",
                from discipline in disciplines
                select new XElement("Discipline",
                       new XAttribute("Name", discipline.NameOfDiscipline),
                       new XAttribute("Teacher", discipline.TeachersSurname),
                       new XElement("CountOfStudentsInGroup", discipline.CountOfStudentsInGroup),
                       new XElement("СountOfHoursForLections", discipline.CountOfHoursForLections),
                       new XElement("CountOfHoursForPractice", discipline.CountOfHoursForPractice),
                       new XElement("AvailabilityOfKursovaya", discipline.AvailabilityOfKursovaya),
                       new XElement("TypeOfFinalControl", discipline.TypeOfFinalControl)
         )));
xdoc.Save(@"XmlDoc.xml");
var file=new XmlDocument();
file.Load(@"XmlDoc.xml");
var temp = file.DocumentElement;
PrintItem(temp);
Console.WriteLine("\n\nСортировка по Преподавателю и кол-ву студентов в группе\n\n");
XDocument xelement = XDocument.Load(@"XmlDoc.xml");
IEnumerable<XElement> sort = from t in xelement.Root.Elements("Discipline")
                               orderby t.Attribute("Teacher").Value,
                               t.Element("CountOfStudentsInGroup").Value
                               select t;

XDocument xdoc2 = new XDocument
        (
            new XElement("disciplines",   
                from discipline in sort
                select new XElement("Discipline",
                       new XAttribute("Name", discipline.Attribute("Name").Value),
                       new XAttribute("Teacher", discipline.Attribute("Teacher").Value),
                       new XElement("CountOfStudentsInGroup", discipline.Element("CountOfStudentsInGroup").Value),
                       new XElement("СountOfHoursForLections", discipline.Element("СountOfHoursForLections").Value),
                       new XElement("CountOfHoursForPractice", discipline.Element("CountOfHoursForPractice").Value),
                       new XElement("AvailabilityOfKursovaya", discipline.Element("AvailabilityOfKursovaya").Value),
                       new XElement("TypeOfFinalControl", discipline.Element("TypeOfFinalControl").Value)
         )));
xdoc2.Save(@"XmlDoc2.xml");
var file2 = new XmlDocument();
file2.Load(@"XmlDoc2.xml");
var temp2 = file2.DocumentElement;
PrintItem(temp2);
Console.WriteLine("\n\nДисциплины, имеющие курсовую работу: ");
XDocument xdoc3 = XDocument.Load(@"XmlDoc.xml");
bool flag = false;
foreach(XElement element in xdoc3.Element("disciplines").Elements("Discipline"))
{
    XElement disc = element.Element("Name");
    XElement kursach = element.Element("AvailabilityOfKursovaya");
    if ((disc != null) && (kursach != null) & Convert.ToBoolean(kursach))
    {
        Console.WriteLine(kursach.Value);
        flag = true;
    }
}
if(!flag)
    Console.WriteLine("Таких дисциплин нет");
Console.Write("\n\nФамилия преподавателя с наибольшим количеством экзаменов: ");
XDocument xdoc4 = XDocument.Load(@"XmlDoc2.xml");
List<string> list = new List<string>();
foreach (XElement element in xdoc4.Element("disciplines").Elements("Discipline"))
{
    XAttribute teacher = element.Attribute("Teacher");
    XElement ekz = element.Element("TypeOfFinalControl");
    if ((teacher != null) && (ekz != null) & ekz.Value=="экзамен")
    {
        list.Add(teacher.Value);
    }
}
int count1 = 0;
string prepod = "";
for (int i = 0; i < list.Count; i++)
{
    int tempp = 0;
    for (int j = 0; j < list.Count; j++)
    {
        if (list[i] == list[j])
            tempp++;
    }
    if (tempp > count1)
    {
        prepod = list[i];
        count1 = tempp;
    }
}
Console.Write(prepod);
Console.WriteLine("\n\n\n");
Console.WriteLine("Количество практических занятий по каждой дисциплине:");
List<string> tmppredmeti=new List<string>();
XDocument xdoc5 = XDocument.Load(@"XmlDoc.xml");
foreach (XElement el1 in xdoc5.Element("disciplines").Elements("Discipline"))
{
    int cofhours = 0;
    foreach (XElement el2 in xdoc5.Element("disciplines").Elements("Discipline"))
    {
        if (el1.Attribute("Name").Value == el2.Attribute("Name").Value)
        {
            cofhours += Convert.ToInt32(el1.Element("CountOfHoursForPractice").Value);
        }
        bool newflag = false;
        foreach(var tmp in tmppredmeti)
        {
            if(tmp== el1.Attribute("Name").Value)
            {
                newflag = true;
                break;
            }
        }
        if (!newflag)
            Console.WriteLine($"Дисциплина {el1.Attribute("Name").Value} с количеством часов: {el1.Element("CountOfHoursForPractice").Value}");
        tmppredmeti.Add(el1.Attribute("Name").Value);
    }
}
Console.WriteLine("\n\n\n");
Console.WriteLine("Группировка");
XDocument xdoc6 = XDocument.Load(@"XmlDoc.xml");
List<Discipline> listforgroup = new List<Discipline>();
var discc = from datafromfile in xdoc6.Element("disciplines").Elements("Discipline")
           select new Discipline
           {
               NameOfDiscipline = (string)datafromfile.Attribute("Name"),
               TeachersSurname = (string)datafromfile.Attribute("Teacher"),
               CountOfStudentsInGroup = (int)datafromfile.Element("CountOfStudentsInGroup"),
               CountOfHoursForLections = (int)datafromfile.Element("СountOfHoursForLections"),
               CountOfHoursForPractice = (int)datafromfile.Element("CountOfHoursForPractice"),
               AvailabilityOfKursovaya = (bool)datafromfile.Element("AvailabilityOfKursovaya"),
               TypeOfFinalControl = (string)datafromfile.Element("TypeOfFinalControl")
           };
foreach (var zn in discc)
    listforgroup.Add(zn);
var res = from Discipline in listforgroup group Discipline by Discipline.TeachersSurname;
foreach (var r in res)
{
    Console.WriteLine(r.Key);
    foreach (var d in r)
    {
        Console.WriteLine(d.NameOfDiscipline);

    }
    Console.WriteLine();
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
