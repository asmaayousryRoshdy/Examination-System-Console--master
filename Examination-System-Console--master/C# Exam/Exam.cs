using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public enum ExamType
    {
        Practical = 1,
        Final = 2,
        
    }
    public abstract class Exam
    {
        public int time { get; set; }
        public int numberOfQuestions { get; set; }
        public int grade { get; set; }
        public Question[] questionList { get; set; }
        public Answers[] answerList { get; set; }
        public abstract ExamType examType { get; set; }

        public Exam() { }
        public Exam(int _time , int _numberOfQuestions) 
        { 
            time = _time;
            numberOfQuestions = _numberOfQuestions;
            grade = 0;
            questionList = new Question[numberOfQuestions];
            answerList = new Answers[numberOfQuestions];
        }

        public virtual void PrintExam()
        {
            for(int i =0;  i < questionList.Length; i++)
            {
                answerList[i] = new Answers();
                Console.WriteLine(questionList[i]);
                Console.WriteLine("___________________________");
                int id; string answer=" ";
                if (questionList[i].GetType().Name == "MCQquestion")
                {
                    answer = Console.ReadLine();
                    answerList[i].AnswerText = answer;
                }
                else
                {
                    id= int.Parse(Console.ReadLine());
                    answerList[i].AnswerId = id;
                    for(int k= 0;  k < questionList.Length; k++)
                    {
                        if (questionList[i].AnswerList[k].AnswerId == id)
                        {
                            answerList[i].AnswerText = questionList[i].AnswerList[k].AnswerText;

                        }
                    }
                }
                Console.WriteLine("____________________________");
            }
        }

    }
}
