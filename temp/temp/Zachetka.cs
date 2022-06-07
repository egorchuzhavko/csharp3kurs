using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    internal class Zachetka
    {
        private int kurs;
        private int semestr;
        private string numberGroup;
        private string fio;
        private int numberZachBook;
        private List<Sessia> sessias = new List<Sessia>();
        public int Kurs
        {
            get { return kurs; }
            set
            {
                try
                {
                    if (value > 0 && value.GetType() == typeof(int))
                    {
                        kurs = value;
                    }
                    else
                    {
                        throw new InvalidKursAndSemestrException("Введенно неверное значение курса");
                    }
                }
                catch (InvalidKursAndSemestrException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
        public int Semestr
        {
            get { return semestr; }
            set
            {
                try
                {
                    if (value > 0 && value.GetType() == typeof(int))
                    {
                        semestr = value;
                    }
                    else
                    {
                        throw new InvalidKursAndSemestrException("Введенно неверное значение семестра");
                    }
                }
                catch (InvalidKursAndSemestrException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
        public string NumberGroup
        {
            get { return numberGroup; }
            set
            {
                try
                {
                    if (char.IsLetter(value[0]) && value[1] == '-' && char.IsDigit(value[2])
                    && char.IsDigit(value[3]) && char.IsDigit(value[4]) && value.Length == 5)
                    {
                        numberGroup = value;
                    }
                    else
                    {
                        throw new NumberOfGroupException("Введенно неверное значение группы");
                    }
                }
                catch (NumberOfGroupException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
        public string Fio
        {
            get { return fio; }
            set
            {
                try
                {
                    string[] mas = value.Split(' ');
                    if (char.IsUpper(mas[0][0]) && char.IsUpper(mas[1][0]) && char.IsUpper(mas[2][0]))
                    {
                        fio = value;
                    }
                    else
                    {
                        throw new FIOAndNameOfDistiplinaException("Введен некорректный формат ФИО");
                    }
                }
                catch (FIOAndNameOfDistiplinaException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
        public int NumberZacBook
        {
            get { return numberZachBook; }
            set
            {
                try
                {
                    if (10000000 <= value && value < 100000000 && value.GetType() == typeof(int))
                    {
                        numberZachBook = value;
                    }
                    else
                    {
                        throw new NumberZachetkaException("Введенно неверное значение номера зачетки");
                    }
                }
                catch (NumberZachetkaException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
        public List<Sessia> Sessias
        {
            get { return sessias; }
            set { sessias = value; }
        }
        public Zachetka(int kurs, int semestr, string numberGroup, string fio, int numberZacBook, Sessia sessias)
        {
            Kurs = kurs;
            Semestr = semestr;
            NumberGroup = numberGroup;
            Fio = fio;
            NumberZacBook = numberZacBook;
            Sessias.Add(sessias);
        }
        public override string ToString()
        {
            string sesiaSTR = "";
            foreach (var item in Sessias)
            {
                sesiaSTR += item;
            }
            return $"\nКурс: {kurs}\nСеместр: {semestr}\nНомер Группы: {numberGroup}\nФИО: {fio}\nНомер зачетки: {numberZachBook} {sesiaSTR} \n--------------------------";
        }
    }

    class Sessia
    {
        private string name;
        private int mark;
        public string Name
        {
            get { return name; }
            set
            {
                try
                {
                    string[] mas = value.Split(' ');
                    if (char.IsUpper(mas[0][0]) && char.IsUpper(mas[1][0]) && char.IsUpper(mas[2][0]))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new FIOAndNameOfDistiplinaException("Введен некорректный формат названия дисциплины");
                    }
                }
                catch (FIOAndNameOfDistiplinaException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
        public int Mark
        {
            get { return mark; }
            set
            {
                try
                {
                    if (value > 0 && value < 11)
                    {
                        mark = value;
                    }
                    else
                    {
                        throw new MarkException("Введенно неверное значение оценки");
                    }
                }
                catch (MarkException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
        public Sessia(string name, int mark)
        {
            this.name = name;
            this.mark = mark;
        }

        public override string ToString()
        {
            return $"\nНазвание сессии: {name}\nОценка: {mark}";
        }
    }

    class InvalidKursAndSemestrException : Exception
    {
        public InvalidKursAndSemestrException(string message) : base(message) { }
    }
    class NumberZachetkaException : Exception
    {
        public NumberZachetkaException(string message) : base(message) { }
    }
    class NumberOfGroupException : Exception
    {
        public NumberOfGroupException(string message) : base(message) { }
    }
    class FIOAndNameOfDistiplinaException : Exception
    {
        public FIOAndNameOfDistiplinaException(string message) : base(message) { }
    }
    class MarkException : Exception
    {
        public MarkException(string message) : base(message) { }
    }
}
