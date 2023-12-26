using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public class PracticalExam : Exam
    {
        public override ExamType examType { get; set; } = ExamType.Practical;
        public PracticalExam(int _time, int _numberOfQuestions) : base(_time, _numberOfQuestions)
        {
            answerList = new Answers[numberOfQuestions];
        }

        public override void PrintExam()
        {
            base.PrintExam();
            PrintPracticalExamResult();
        }

        public void PrintPracticalExamResult()
        {
            Console.Clear();
            Console.WriteLine("The model right Answers :");
            
            for (int i = 0; i < questionList.Length; i++)
            {
                if (questionList[i].GetType().Name == "TrueOrFalseQuestion")
                {
                    string answer = "";
                    string[] arr = questionList[i].RightAnswer.AnswerText.Split(',');
                    for (int j = 0; j < arr?.Length; j++)
                    {
                        if (arr[j] == questionList[i].AnswerList[j].AnswerText)
                        {
                            answer += questionList[i].AnswerList[j].AnswerText + " ";
                        }
                    }
                    Console.WriteLine($"Q{i + 1} :: {answer}\n_______________________");
                }
                else
                {
                    Console.WriteLine($"Q{i + 1} :: {questionList[i].RightAnswer.AnswerText}\n_______________________");
                }

                
            }
        }
    }
}
