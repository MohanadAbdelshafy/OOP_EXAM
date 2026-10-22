
using OOP_EXAM.Classes;
using OOP_EXAM.Classes.ExamTypes;
using OOP_EXAM.Classes.QuestionTypes;

namespace OOP_EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Subject subject = new Subject(10, "C# Programming");


            //Console.WriteLine("Enter Exam Type (1 for Practical, 2 for Final):");
            //int examType = int.Parse(Console.ReadLine());
            //int time;
            //do
            //{
            //    Console.WriteLine("Enter Exam Time in minutes (between 30 and 180):");
            //    time = int.Parse(Console.ReadLine());

            //    if (time < 30 || time > 180)
            //    {
            //        Console.WriteLine("Invalid time! Time must be between 30 and 180.");
            //    }
            //} while (time < 30 || time > 180);

            //Console.WriteLine("Enter Number Of Questions:");
            //int numQuestions = int.Parse(Console.ReadLine());

            //Exam exam;
            //if (examType == 1)
            //{
            //    exam = new PracticalExam(TimeSpan.FromMinutes(time), numQuestions);
            //}
            //else
            //{
            //    exam = new FinalExam(TimeSpan.FromMinutes(time), numQuestions);
            //}

            //for (int i = 0; i < numQuestions; i++)
            //{
            //    Console.WriteLine($"\n--- Data for Question {i + 1} ---");

               
            //    int questionType = 2; 
            //    if (examType == 2)
            //    {
            //        Console.WriteLine("Enter Question Type (1 for True/False, 2 for MCQ):");
            //        questionType = int.Parse(Console.ReadLine());
            //    }

            //    Console.WriteLine("Enter Question Body:");
            //    string body = Console.ReadLine();

            //    Console.WriteLine("Enter Question Mark:");
            //    int mark = int.Parse(Console.ReadLine());

            //    Question question;

            //    if (questionType == 1) 
            //    {
            //        question = new TrueFalseQuestion("True/False Question", body, mark);
            //        Console.WriteLine("Enter the right answer ID (1 for True, 2 for False):");
            //        int rightId = int.Parse(Console.ReadLine());

            //        question.CorrectAnswer = question.AnswerList[rightId - 1];
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Enter the number of choices for this MCQ:");
            //        int choicesCount = int.Parse(Console.ReadLine());

            //        question = new McqQuestion("MCQ Question", body, mark, choicesCount);

            //        for (int j = 0; j < choicesCount; j++)
            //        {
            //            Console.WriteLine($"Enter Choice {j + 1} text:");
            //            string choiceText = Console.ReadLine();
            //            question.AnswerList[j] = new Answers(j + 1, choiceText);
            //        }

            //        Console.WriteLine("Enter the right answer ID:");
            //       int rightId = int.Parse(Console.ReadLine());
            //       question.CorrectAnswer = question.AnswerList[rightId - 1];
       
            //    }
            //    exam.Questions[i] = question;
            //}
            //subject.CreateExam(exam);

            //Console.Clear();
            //Console.WriteLine("Do you want to start the exam? (y/n)");
            //if (Console.ReadLine().ToLower() == "y")
            //{
            //    subject.SubjectExam.ShowExam();
              
            //}
            //Console.WriteLine($"Exam Time: {exam.ExamTime}");  

        }
    }
}
  