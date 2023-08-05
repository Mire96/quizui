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
        public AnswerModel CorrectAnswer { get; set; }

        public QuestionModel()
        {

        }

        public QuestionModel(string questionText, List<AnswerModel> answerList, AnswerModel correctAnswer)
        {
            ID = -1;
            QuestionText = questionText;
            AnswerList = answerList;
            CorrectAnswer = correctAnswer;  
        }

        //Used for creating copies of real questions to check when submitting tests
        public QuestionModel(QuestionModel question)
        {
            this.QuestionText = question.QuestionText;
            this.ID = question.ID;
            this.AnswerList = new List<AnswerModel>();
            this.CorrectAnswer = question.CorrectAnswer;
        }

        public override string ToString()
        {
            return QuestionText;
        }
    }
}
