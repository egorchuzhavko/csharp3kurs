using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{ 
    internal class Discipline
    {
        private string nameOfDiscipline;
        private string teachersSurname;
        private int countOfStudentsInGroup;
        private int countOfHoursForLections;
        private int countOfHoursForPractice;
        private bool availabilityOfKursovaya;
        private string typeOfFinalControl;

        public Discipline() { }

        public Discipline(string s1,string s2, int i1, int i2, int i3, bool b, string s3)
        {
            NameOfDiscipline = s1;
            TeachersSurname = s2;
            CountOfStudentsInGroup = i1;
            CountOfHoursForLections = i2;
            CountOfHoursForPractice = i3;
            AvailabilityOfKursovaya = b;
            TypeOfFinalControl = s3;
        }

        public string NameOfDiscipline
        {
            get { return nameOfDiscipline; }
            set
            {
                try
                {
                    if (!char.IsUpper(value[0]))
                    {
                        throw new InvalidName("Имя дисциплины начинается не с большой буквы");
                    }
                    nameOfDiscipline = value;
                }
                catch (InvalidName e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public string TeachersSurname
        {
            get { return teachersSurname;}
            set
            {
                try
                {
                    if (!char.IsUpper(value[0]))
                    {
                        throw new InvalidName("Имя преподавателя начинается не с большой буквы");
                    }
                    teachersSurname = value;
                }
                catch (InvalidName e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public int CountOfStudentsInGroup
        {
            get { return countOfStudentsInGroup;}
            set
            {
                try
                {
                    if (value <= 0 & value.GetType() != typeof(int))
                    {
                        throw new InvalidCount("Неверное количество людей в группе");
                    }
                    countOfStudentsInGroup = value;
                }
                catch (InvalidCount e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public int CountOfHoursForLections
        {
            get { return countOfHoursForLections;}
            set
            {
                try
                {
                    if (value <= 0 & value.GetType() != typeof(int))
                    {
                        throw new InvalidCount("Неверное количество часов лекций");
                    }
                    countOfHoursForLections = value;
                }
                catch (InvalidCount e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public int CountOfHoursForPractice
        {
            get { return countOfHoursForPractice;}
            set
            {
                try
                {
                    if (value <= 0 & value.GetType() != typeof(int))
                    {
                        throw new InvalidCount("Неверное количество часов для практики");
                    }
                    countOfHoursForPractice = value;
                }
                catch (InvalidCount e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public bool AvailabilityOfKursovaya
        {
            get { return availabilityOfKursovaya;}
            set
            {
                try
                {
                    if (value.GetType() != typeof(bool))
                    {
                        throw new InvalidKursovaya("Неверный тип переменной для наличия курсовой");
                    }
                    availabilityOfKursovaya = value;
                }
                catch (InvalidKursovaya e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public string TypeOfFinalControl
        {
            get { return typeOfFinalControl; }
            set
            {
                try
                {
                    if (value != "зачёт" & value != "экзамен")
                    {
                        throw new InvalidTypeOfFinalControl("Неверный тип итогового контроля");
                    }
                    typeOfFinalControl = value;
                }
                catch (InvalidTypeOfFinalControl e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public override string ToString()
        {
            return $"Имя дисциплины: {NameOfDiscipline}\nФамилия преподавателя: {TeachersSurname}\n" +
                $"Кол-во студентов в группе: {CountOfStudentsInGroup}\nКол-во часов для лекций: {CountOfHoursForLections}\n" +
                $"Кол-во часов для практики: {CountOfHoursForPractice}\nВозможная курсовая: {AvailabilityOfKursovaya}\nТип финального контроля: {TypeOfFinalControl}";
        }
    }
}

class InvalidName: Exception
{
    public InvalidName(string s) : base(s) { }
}

class InvalidCount : Exception
{
    public InvalidCount(string s) : base(s) { }
}

class InvalidKursovaya : Exception
{
    public InvalidKursovaya(string s) : base(s) { }
}

class InvalidTypeOfFinalControl : Exception
{
    public InvalidTypeOfFinalControl(string s) : base(s) { }
}