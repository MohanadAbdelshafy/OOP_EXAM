using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.Classes
{
    public abstract class Exam :ICloneable
    {
        public TimeSpan ExamTime { get; set; }
        public int numberOfQuestions { get; set; }
        public Question[]? Questions { get; set; }
        public Exam(TimeSpan examTime): this(examTime, 0)
        {
        }

        protected Exam(TimeSpan examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            this.numberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];

        }
        public abstract void ShowExam();
        public abstract object Clone();
        public override string ToString()=> $"Exam Time: {ExamTime.TotalMinutes} Minutes, Number of Questions: {numberOfQuestions}";
        
    }

}
