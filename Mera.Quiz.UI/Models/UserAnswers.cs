using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mera.Quiz.UI.Models
{
	public class UserAnswers
	{
		public int ID { get; set; }

		public QuestionModel Question { get; set; }

		public AnswerModel ChosenAnswer { get; set; }
	}
}
