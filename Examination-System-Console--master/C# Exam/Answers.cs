using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public class Answers
    {
		private int answerId;
		private string answerText;

		public string AnswerText
        {
			get { return answerText; }
			set { answerText = value; }
		}


		public int AnswerId
		{
			get { return answerId; }
			set { answerId = value; }
		}

		public Answers()
		{

		}
        public Answers(int _answerId , string _answerText)
        {
			answerId = _answerId;
			AnswerText = _answerText;
        }

    }
}
