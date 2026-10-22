using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.Classes
{
    public abstract class Question : ICloneable ,IComparable<Question>
    {
        protected Question(string? header, string? body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answers[]? AnswerList { get; set; }
        public Answers? CorrectAnswer { get; set; }

        override public string ToString() => $"Header: {Header}, Body: {Body}, Mark: {Mark}";
        public abstract object Clone();
        public int CompareTo(Question? other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }

    }
}
