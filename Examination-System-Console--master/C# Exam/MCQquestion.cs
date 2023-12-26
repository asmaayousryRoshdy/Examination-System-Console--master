using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public class MCQquestion : Question
    {
        public override string header => "Mcq Question (only choose one choise )";

        public MCQquestion(string _questionBody = " ", int _marks = 0) : base(_questionBody, _marks)
        {
            AnswerList = new Answers[3];
        }

        public override string ToString()
        {
            return $"{header}\t\tMarks({Marks})\n{questionBody}\n" +
                $"1){AnswerList[0].AnswerText}\n2){AnswerList[1].AnswerText}\n3){AnswerList[2].AnswerText}";
        }

        public static MCQquestion AddMCQQuestion()
        {
            MCQquestion question = new MCQquestion();
            Console.WriteLine(question.header);
            Console.WriteLine("Please Enter The Body Of Question:");
            question.questionBody = Console.ReadLine();
            Console.WriteLine("Please Enter The Marks Of Question:");
            question.Marks = int.Parse(Console.ReadLine());

            for (int i = 0; i < question.AnswerList?.Length; i++)
            {
                question.AnswerList[i] = new Answers();
                Console.WriteLine($"Please Enter The Choice Number {i + 1} : ");
                question.AnswerList[i].AnswerText = Console.ReadLine();
                question.AnswerList[i].AnswerId = i + 1;
            }
            question.RightAnswer = new Answers();
            string answer = "";
            do
            {
                Console.WriteLine($"Please Enter The Right Answer for Quesion from 1 to 3");
                answer = Console.ReadLine();
            } while (!(answer is string));
            question.RightAnswer.AnswerText = answer;
            return question;
        }

        //public static MCQquestion AddMCQQuestion()
        //{
        //    MCQquestion MCQquestion = new MCQquestion();
        //    Console.WriteLine(MCQquestion.header);
        //    Console.WriteLine("Please enter the body of the question");
        //    MCQquestion.QuestionBody = Console.ReadLine();
        //    Console.WriteLine("Please enter the Mark of the question");
        //    MCQquestion.Marks = int.Parse(Console.ReadLine());
        //    for(int i = 0; i < MCQquestion.AnswerList?.Length; i++)
        //    {
        //        MCQquestion.AnswerList[i] = new Answers();
        //        Console.WriteLine($"Please enter the choise number {i+1}");
        //        MCQquestion.AnswerList[i].AnswerText = Console.ReadLine();
        //        MCQquestion.AnswerList[i].AnswerId = i+1;
        //    }
        //    MCQquestion.RightAnswer = new Answers();
        //    int id;
        //    do
        //    {
        //        Console.WriteLine($"Please Enter The Right Answer for Quesion from 1 to 3");
        //    } while (!int.TryParse(Console.ReadLine(), out id));
        //    MCQquestion.RightAnswer.AnswerId = id;
        //    MCQquestion.RightAnswer.AnswerText = MCQquestion.AnswerList[id - 1].AnswerText;
        //    return MCQquestion;
        //}
    }
}
