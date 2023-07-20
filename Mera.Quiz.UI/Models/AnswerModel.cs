using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mera.Quiz.UI.Models


{
    public class AnswerModel : INotifyPropertyChanged
    {
        private bool _isCorrect;

		[Browsable(false)]
		public int ID { get; set; }
        public string AnswerText { get; set; } = "Example answer";
        public bool isCorrect { 
            get => _isCorrect;
            set
            {
                if (_isCorrect != value)
                {
                    _isCorrect = value;
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(isCorrect)));
                }
            }
        }

        public AnswerModel()
        {

        }

        public AnswerModel(string answerText, bool isCorrect)
        {
            ID = -1;
            AnswerText = answerText;
            this.isCorrect = isCorrect;
        }


        //Used for creating copies of actual answers to check during quiz submission
        public AnswerModel(AnswerModel answer)
        {
            this.ID = answer.ID;
            this.AnswerText = answer.AnswerText;
            this.isCorrect = false;
        }

		public event PropertyChangedEventHandler PropertyChanged;

		public override bool Equals(object obj)
        {
            return obj is AnswerModel model &&
                   ID == model.ID &&
                   AnswerText == model.AnswerText &&
                   isCorrect == model.isCorrect;
        }
    }
}
