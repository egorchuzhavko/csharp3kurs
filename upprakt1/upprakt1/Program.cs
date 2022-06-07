using System;

namespace upprakt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string[] subjects = { "КроссПлатформПрог", "КПиЯП", "ОАиП", "СПО", "СиСПО" };
            DateTime data = new DateTime(2020, 11, 11);
            Person chel = new Person("Дима", "Пупкин", data);
            Student std = new Student(chel, Education.Specialist, 992);
            Exam[] exm = new Exam[3];
            for(int i = 0; i < 3; i++)
            {
                exm[i] = new Exam();
                exm[i].Mark = r.Next(1,10);
                exm[i].Subject = subjects[r.Next(0, 5)];
                exm[i].Dateofexam = data;
            }
            std.Exam = exm;
            Console.WriteLine(std.ToShortString());
            Console.WriteLine(std[Education.Specialist]);
            Console.WriteLine(std[Education.Bachelor]);
            Console.WriteLine(std[Education.SecondEducation]);
            DateTime dat = new DateTime(2019, 12, 12);
            Person chel2 = new Person("Даниил", "Григоренко", dat);
            Exam[] exm2 = new Exam[4];
            for (int i = 0; i < 4; i++)
            {
                exm2[i] = new Exam();
                exm2[i].Mark = r.Next(1, 10);
                exm2[i].Subject = subjects[r.Next(0, 5)];
                exm2[i].Dateofexam = data;
            }
            std.Exam = exm2;
            std.Persn = chel2;
            std.Numberofgroup = 192;
            std.Ed = Education.SecondEducation;
            Console.WriteLine("\n"+std.ToString());
            Exam[] exm3 = new Exam[2];
            for (int i = 0; i < 2; i++)
            {
                exm3[i] = new Exam();
                exm3[i].Mark = r.Next(1, 10);
                exm3[i].Subject = subjects[r.Next(0, 5)];
                exm3[i].Dateofexam = data;
            }
            std.AddExams(exm3);
            Console.WriteLine("\n" + std.ToString());

            int tickstart=0;
            int tickfinish=0;
            Exam[] exm5 = new Exam[1000000];
            for (int i = 0; i < exm5.Length; i++)
            {
                exm5[i] = new Exam();
            }
            tickstart = Environment.TickCount;
            for (int i = 0; i < exm5.Length; i++)
            {
                exm5[i].Mark = r.Next(1, 10);
                exm5[i].Subject = subjects[r.Next(0, 5)];
                exm5[i].Dateofexam = data;
            }
            tickfinish = Environment.TickCount;
            Console.WriteLine($"Одномерный массив: {tickstart} *** {tickfinish} *** {tickfinish - tickstart}");

            tickstart = 0;
            tickfinish = 0;
            Exam[,] exm6 = new Exam[20000, 20000];
            for(int i = 0; i < 20000; i++)
            {
                for(int j = 0; j < 20000; j++)
                {
                    exm6[i, j] = new Exam();
                }
            }
            tickstart = Environment.TickCount;
            for (int i = 0; i < 20000; i++)
            {
                for (int j = 0; j < 20000; j++)
                {
                    exm6[i,j].Mark = r.Next(1, 10);
                    exm6[i,j].Subject = subjects[r.Next(0, 5)];
                    exm6[i,j].Dateofexam = data;
                }
            }
            tickfinish = Environment.TickCount;
            Console.WriteLine($"Двумерный прямоугольный массив: {tickstart} *** {tickfinish} *** {tickfinish - tickstart}");

            tickstart = 0;
            tickfinish = 0;
            Exam[][] exm7 = new Exam[1000][];
            for (int i = 0; i < exm7.Length; i++)
            {
                exm7[i] = new Exam[1000];
                for (int j = 0; j < exm7.Length; j++)
                {
                    exm7[i][j] = new Exam();
                }
            }
            tickstart = Environment.TickCount;
            for (int i = 0; i < exm7.GetLength(1); i++)
            {
                for (int j = 0; j < exm7.GetLength(2); j++)
                {
                    exm7[i][j].Mark = r.Next(1, 10);
                    exm7[i][j].Subject = subjects[r.Next(0, 5)];
                    exm7[i][j].Dateofexam = data;
                }
            }
            tickfinish = Environment.TickCount;
            Console.WriteLine($"Двумерный ступенчатый массив: {tickstart} *** {tickfinish} *** {tickfinish - tickstart}");
        }
    }
}
