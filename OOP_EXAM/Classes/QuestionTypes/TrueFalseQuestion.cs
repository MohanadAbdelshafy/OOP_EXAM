using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.Classes.QuestionTypes
{
    public class TrueFalseQuestion : Question
    {

        public TrueFalseQuestion(string? header, string? body, int mark) : base(header, body, mark) 
        {
            AnswerList = new Answers[2]
                {
                new Answers(1, "True"),
                new Answers(2, "False")
                };

        }
        public override object Clone() => new TrueFalseQuestion(Header, Body, Mark) { CorrectAnswer = this.CorrectAnswer };
    }
}
