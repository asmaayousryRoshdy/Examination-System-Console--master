using System.Diagnostics;

namespace C__Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C#");
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Take the Exam now ? (Y | N)");
            if (char.Parse(Console.ReadLine()) == 'Y')
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                subject.ExamSubject.PrintExam();
                s.Stop();
                Console.WriteLine($"the Elapsed Time ={s.Elapsed}");
            }
        }
    }
}