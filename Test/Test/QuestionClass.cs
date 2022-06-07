using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class QuestionClass
    {
        private int questNumv;
        private string question;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private string coranwer;
        private int correctAnswer;
        private int userAnswer;
        public static List<string> coransstr = new List<string>();
        private string ph;

        public int QuestNumv { get { return questNumv; } set { questNumv = value; } }
        public string Question { get { return question; } set { question = value; } }
        public string Answer1 { get { return answer1; } set { answer1 = value; } }
        public string Answer2 { get { return answer2; } set { answer2 = value; } }
        public string Answer3 { get { return answer3; } set { answer3 = value; } }
        public string Answer4 { get { return answer4; } set { answer4 = value; } }
        public int UserAnswer { get { return userAnswer; } set { userAnswer = value; } }
        public int CorrectAnswer { get { return correctAnswer; } set { correctAnswer = value; } }
        public string Coranswer { get { return coranwer; } set { coranwer = value; } }
        public string Ph { get { return ph; } set { ph = value; } }


        public QuestionClass(string photo, int qn, string q, string a1, string a2, string a3, string a4, int ca, string sat)
        {
            Ph = photo;
            QuestNumv = qn;
            Question = q;
            Answer1 = a1;
            Answer2 = a2;
            Answer3 = a3;
            Answer4 = a4;
            CorrectAnswer = ca;
            Coranswer = sat;
            coransstr.Add(Coranswer);
        }

    }
}
