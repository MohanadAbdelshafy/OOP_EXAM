using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.Classes.ExamTypes
{
    //public class FinalExam : Exam
    //{
    //    public FinalExam(TimeSpan examTime,int numberOfQuestions) : base(examTime, numberOfQuestions)
    //    {
    //    }
    //    public override void ShowExam()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("=== Final Exam ===");
    //        int totalGrade = 0;
    //        int studentGrade = 0;

    //        foreach (var q in Questions)
    //        {
    //            Console.WriteLine(q.ToString());
    //            foreach (var ans in q.AnswerList)
    //            {
    //                Console.WriteLine(ans.ToString());
    //            }

    //            Console.Write("Enter your answer ID: ");
    //            int studentAnswer = int.Parse(Console.ReadLine());

    //            totalGrade += q.Mark;
    //            if (studentAnswer == q.CorrectAnswer?.AnswerID)
    //            {
    //                studentGrade += q.Mark;
    //            }
    //            Console.WriteLine("-----------------------");
    //        }

    //        Console.WriteLine($"Your Grade: {studentGrade} / {totalGrade}");
    //    }
    //    public override object Clone() => new FinalExam(ExamTime, numberOfQuestions) { Questions = this.Questions };
    //}
}
