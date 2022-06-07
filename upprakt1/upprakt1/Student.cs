using System;
using System.Collections.Generic;
using System.Text;

namespace upprakt1
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    class Student
    {
        private Person persn;
        private Exam[] exam;
        private Education ed;
        private int numberofgroup;

        public Student() { }

        public Student(Person persn, Education ed, int numberofgroup)
        {
            this.persn = persn;
            this.ed = ed;
            this.numberofgroup = numberofgroup;
        }

        public Person Persn
        {
            get { return persn; }
            set { persn = value; }
        }
        public Education Ed
        {
            get { return ed; }
            set { ed = value; }
        }
        public int Numberofgroup
        {
            get { return numberofgroup; }
            set { numberofgroup = value; }
        }
        public Exam[] Exam
        {
            get { return exam; }
            set { exam = value; }
        }

        public double AvgMark
        {
            get
            {
                double n = 0;
                for(int i = 0; i < exam.Length; i++)
                    n += exam[i].Mark;
                return n / exam.Length;
            }
        }

        public bool this[Education n]
        {
            get
            {
                if (ed == n)
                    return true;
                return false;
            }
        }

        public void AddExams(params Exam[] ex)
        {
            if (ex?.Length == 0)
                return;
            if (exam == null)
                exam = Array.Empty<Exam>();
            int oldl = exam.Length;
            Array.Resize(ref exam, exam.Length + ex.Length);
            Array.Copy(ex, 0, exam, oldl, ex.Length);
        }

        public override string ToString()
        {
            string ekzameni = "";
            for (int i = 0; i < exam.Length; i++)
                ekzameni += exam[i].Subject + " ";
            return $"{persn.ToString()}\nЭкзамены: {ekzameni}\nEducation: {ed}\nНомер группы: {numberofgroup}\nСредний балл: {AvgMark}";
        }

        public virtual string ToShortString()
        {
            return $"{persn.ToString()}\nОбразование: {ed}\nНомер группы: {numberofgroup}\nСредний балл: {AvgMark}";
        }
    }
}
