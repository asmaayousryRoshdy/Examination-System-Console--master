using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public class TrueOrFalseQ : Question
    {
        public override string header => "True or False Question";

        public TrueOrFalseQ(string _questionBody = " ", int _marks = 0) : base(_questionBody , _marks) 
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");
        }

        public override string ToString()
        {
            return $"{header}\t\tMarks({Marks})\n{questionBody}\n1){AnswerList[0].AnswerText}\t\t\t2){AnswerList[1].AnswerText}";
        }

        public static TrueOrFalseQ AddTOrFQuestion()
        {
            TrueOrFalseQ trueOrFalseQ = new TrueOrFalseQ();
            Console.WriteLine(trueOrFalseQ.header);
            Console.WriteLine("Please enter the body of the question");
            trueOrFalseQ.QuestionBody = Console.ReadLine();
            Console.WriteLine("Please enter the Mark of the question");
            trueOrFalseQ.Marks= int.Parse(Console.ReadLine());
            trueOrFalseQ.RightAnswer = new Answers();
            int id;
            do
            {
                Console.WriteLine($"Please Enter The Right Answer For the Question [1 for True, 2 for False]");
            } while (!int.TryParse(Console.ReadLine(), out id));
            trueOrFalseQ.RightAnswer.AnswerId = id;
            trueOrFalseQ.RightAnswer.AnswerText = trueOrFalseQ[id].AnswerText;
            return trueOrFalseQ;
        }

    }
}
