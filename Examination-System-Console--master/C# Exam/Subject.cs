using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam ExamSubject { get; set; }

        public Subject(int id , string name , Exam examSubject)
        {
            Id = id;
            Name = name;
            ExamSubject = examSubject;
        }
        public Subject(int id, string name) : this(id, name, new PracticalExam(15, 3)){ }

        public override string ToString()
        {
            return $"Subject Name {Name}\n Subject Id {Id}\n Exam Type {ExamSubject}";
        }

        public void CreateExam()
        {
            int type;
            do
            {
                Console.WriteLine("Please Choose The Type of The Exam [1 for Practical, 2 for Final]");
            } while (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 2);
            ExamSubject.examType = (ExamType)type;
            Console.WriteLine("Please Choose The Time of The Exam in Minutes :");
            int time = int.Parse(Console.ReadLine());
            
            ExamSubject.time = time;
            Console.WriteLine("Please Enter Number of Questions: ");
            int numberofQuestions = int.Parse(Console.ReadLine());
            Console.Clear();
            if (ExamSubject.examType == ExamType.Practical)
            {
                ExamSubject = new PracticalExam(time, numberofQuestions);
                ExamSubject.questionList = Question.CreatePracticalQuestion(numberofQuestions);
            }
            else
            {
                ExamSubject = new FinalExam(time, numberofQuestions);
                ExamSubject.questionList = Question.CreateFinalQuestion(numberofQuestions);
            }
            for (int i = 0; i < ExamSubject.questionList.Length; i++)
            {
                ExamSubject.grade += ExamSubject.questionList[i].Marks;
            }
        }
    }
}
