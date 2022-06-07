using System;
using System.Collections.Generic;
using System.Text;

namespace upprakt1
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime birthday;

        public Person() { }

        public Person(string name, string surname, DateTime birthday)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }

        public void setName(string name) { this.name = name; }
        public void setSurname(string surname) { this.surname = surname; }
        public void setBirthday(DateTime birthday) { this.birthday = birthday; }

        public string getName() => name;
        public string getSurname() => surname;
        public DateTime getBirthday() => birthday;
        public int year
        {
            get { return birthday.Year; }
            set
            {
                int day = birthday.Day;
                int month = birthday.Month;
                birthday = new DateTime(value, month, day);
            }
        }

        public virtual string ToString()
        {
            return $"Name: {name}\nSurname: {surname}\nBirthday: {birthday.ToShortDateString()}";
        }
        public virtual string ToShortString()
        {
            return $"Name: {name}\nSurname: {surname}";
        }
    }
}
