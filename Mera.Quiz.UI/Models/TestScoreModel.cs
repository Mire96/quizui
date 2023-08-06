using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mera.Quiz.UI.Models
{
	public class TestScoreModel
	{
		public int ID { get; set; }

        public TestModel Test { get; set; }
        public UserModel User { get; set; }

		public int Score { get; set; }

		public DateTime DateTaken { get; set; }

		public List<UserAnswers> UserAnswers { get; set; }
	}
}
