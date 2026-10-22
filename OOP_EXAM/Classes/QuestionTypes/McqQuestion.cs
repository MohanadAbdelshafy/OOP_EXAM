using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.Classes.QuestionTypes
{
    public class McqQuestion : Question
    {
        public McqQuestion(string? header, string? body, int mark,int numberofchoices) : base(header, body, mark)
        {
            AnswerList = new Answers[numberofchoices];
        }

        public override object Clone() => new McqQuestion(Header, Body, Mark,AnswerList.Length) { CorrectAnswer = this.CorrectAnswer };
    }
}
