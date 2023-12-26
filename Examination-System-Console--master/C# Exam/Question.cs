using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public abstract class Question
    {
        #region properties
        public abstract string header { get; }
        protected string questionBody;
        protected int marks;
        private Answers rightAnswer;
        private Answers[] answerList;

        public Answers[] AnswerList
        {
            get { return answerList; }
            set { answerList = value; }
        }

        public Answers this[int id]
        {
            get
            {
                for (int i = 0; i < answerList?.Length; i++)
                {
                    if (answerList[i].AnswerId == id) return answerList[i];
                }
                return new Answers();
            }
        }

        public Answers this[string text]
        {
            get
            {
                for (int i = 0; i < answerList?.Length; i++)
                {
                    if (answerList[i].AnswerText == text) return answerList[i];
                }
                return new Answers();
            }
        }


        public Answers RightAnswer
        {
            get { return rightAnswer; }
            set { rightAnswer = value; }
        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string QuestionBody
        {
            get { return questionBody; }
            set { questionBody = value; }
        }

        
        #endregion

        #region Constructors
        public Question()
        {
            
        }

        public Question( string _questionBody , int _marks)
        {
            questionBody = _questionBody;
            marks = _marks;
        }
        #endregion

        
        public static Question[] CreateFinalQuestion(int size)
        {
            Question[] Finalquestions = new Question[size];
            for(int i = 0; i < Finalquestions?.Length; i++)
            {
                
                Console.WriteLine($"Please Choose The Type of the Question Number {i + 1} [1 for T/F Question, 2 for MCQ ] ");
                int questionType = int.Parse(Console.ReadLine());

                if(questionType == 1)
                {
                    Console.WriteLine($"Enter The True or False Question Number {i + 1}");
                    Finalquestions[i] = TrueOrFalseQ.AddTOrFQuestion();
                }
                if(questionType == 2)
                {
                    Console.WriteLine($"Enter The Data of Choose One Question Number {i + 1}");
                    Finalquestions[i] = MCQquestion.AddMCQQuestion();
                }
                Console.Clear();
            }
            return Finalquestions;
        }

        public static Question[] CreatePracticalQuestion(int size)
        {
            Question[] practicalquestions = new Question[size];
            for (int i = 0; i < practicalquestions?.Length; i++)
            {
                Console.WriteLine($"Enter The Data of Choose One Question Number {i + 1}");
                practicalquestions[i] = MCQquestion.AddMCQQuestion();
                Console.Clear();
            }
            return practicalquestions;
        }

    }
    
}
