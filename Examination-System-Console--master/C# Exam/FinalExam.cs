using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public class FinalExam : Exam
    {
        public override ExamType examType { get; set; } = ExamType.Final;
        public FinalExam(int _time , int _numberOfQuestions) : base(_time , _numberOfQuestions) 
        {
            answerList = new Answers[numberOfQuestions];
        }

        public override void PrintExam()
        {
            base.PrintExam();
            PrintFinalExamResult();
        }

        public void PrintFinalExamResult()
        {
            Console.Clear();
            Console.WriteLine("The model right Answers :");
            int userGrade = 0;
            for (int i = 0; i < questionList.Length; i++)
            {
                if (questionList[i].GetType().Name == "MCQQuestions")
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
                    Console.WriteLine($"Q{i + 1} : {questionList[i].QuestionBody}:{answer}");
                }
                else
                {
                    Console.WriteLine($"Q{i + 1} : {questionList[i].QuestionBody}:{questionList[i].RightAnswer.AnswerText}");
                }

                if (answerList[i].AnswerId == questionList[i].RightAnswer.AnswerId)
                {
                    userGrade += questionList[i].Marks;
                }
            }
            Console.WriteLine($"Your Grade is {userGrade} From {grade}");
        }
    }
}
