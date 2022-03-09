using System;
using System.Collections.Generic;
using System.Text;

namespace Mera.Quiz.UI.Models
{
    public class TestModel
    {
        public int ID { get; set; }
        public string TestName { get; set; }
        public List<QuestionModel> QuestionList { get; set; }
        public UserModel UserName { get; set; }
        public int Score { get; set; }
    }
}
