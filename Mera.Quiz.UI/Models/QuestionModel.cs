using System;
using System.Collections.Generic;
using System.Text;

namespace Mera.Quiz.UI.Models

{
    public class QuestionModel
    {
        public int ID { get; set; }
        public string QuestionText { get; set; }
        public List<AnswerModel> AnswerList { get; set; }

        public QuestionModel()
        {

        }

        public QuestionModel(string questionText, List<AnswerModel> answerList)
        {
            ID = -1;
            QuestionText = questionText;
            AnswerList = answerList;
        }

        public override string ToString()
        {
            return QuestionText;
        }
    }
}
