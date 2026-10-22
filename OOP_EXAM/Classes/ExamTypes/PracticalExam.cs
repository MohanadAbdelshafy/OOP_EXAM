using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.Classes.ExamTypes
{
    //public class PracticalExam :Exam
    //{
    //    public PracticalExam(TimeSpan examTime, int numberOfQuestions) : base(examTime, numberOfQuestions)
    //    {
    //    }
    //    public override void ShowExam()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("=== Practical Exam ===");
    //        foreach (var q in Questions) 
    //        {
    //            Console.WriteLine($"Question: {q.ToString()}");
    //            foreach (var ans in q.AnswerList)
    //            {
    //                Console.WriteLine(ans.ToString());
    //            }
    //            Console.Write("Enter your answer ID: ");
    //            Console.ReadLine();
    //            Console.WriteLine("-----------------------");
    //        }
    //        Console.WriteLine("\n--- Right Answers ---");
    //        foreach (var q in Questions)
    //        {
    //            Console.WriteLine($"{q.Body} -> Right Answer: {q.CorrectAnswer?.AnswerText}");
    //        }
    //    }
    //    public override object Clone() => new PracticalExam(ExamTime, numberOfQuestions) { Questions = this.Questions };
    //}
}
