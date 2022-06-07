using System;
using System.Collections.Generic;
using System.Text;

namespace upprakt1
{
    class Exam
    {
        private string subject;
        private int mark;
        private DateTime dateofexam;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public DateTime Dateofexam
        {
            get { return dateofexam; }
            set { dateofexam = value; }
        }

        public Exam() { }

        public Exam(string subject, int mark, DateTime dateofexam)
        {
            this.subject = subject;
            this.mark = mark;
            this.dateofexam = dateofexam;
        }

        public override string ToString()
        {
            return $"Subject: {subject}\nMark: {mark}\nDate of exam {dateofexam}";
        }
    }
}
