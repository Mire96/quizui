using System;
using System.Collections.Generic;
using System.Text;

namespace Mera.Quiz.UI.Models


{
    public class AnswerModel
    {
        public int ID { get; set; }
        public string AnswerText { get; set; }
        public bool isChosen { get; set; }

        public AnswerModel()
        {

        }

        public AnswerModel(string answerText, bool isCorrect)
        {
            ID = -1;
            AnswerText = answerText;
            this.isChosen = isCorrect;
        }


        //Used for creating copies of actual answers to check during quiz submission
        public AnswerModel(AnswerModel answer)
        {
            this.ID = answer.ID;
            this.AnswerText = answer.AnswerText;
            this.isChosen = false;
        }

		public override bool Equals(object obj)
		{
			return obj is AnswerModel model &&
				   AnswerText == model.AnswerText;
		}

		public static bool operator ==(AnswerModel left, AnswerModel right)
		{
			return EqualityComparer<AnswerModel>.Default.Equals(left, right);
		}

		public static bool operator !=(AnswerModel left, AnswerModel right)
		{
			return !(left == right);
		}
	}
}
