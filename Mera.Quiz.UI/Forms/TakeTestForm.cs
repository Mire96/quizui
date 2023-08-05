using Mera.Quiz.UI.API_connection;
using Mera.Quiz.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mera.Quiz.UI.Forms
{
    public partial class TakeTestForm : Form
    {
        private TestModel testModel;
        private List<RadioButton> answerButtonList;
        private List<QuestionModel> submitQuestionList;
        private int currentQuestion;
        private int testScore;
        
        public TakeTestForm(object selectedItem)
        {
            InitializeComponent();
            testModel = (TestModel)selectedItem;
            answerButtonList = new List<RadioButton>();

            //Here we disable the previous question button since we are starting from the first question
            previousBtnQuestion.Enabled = false;

            //Here we add all questions to local submitQuestionList variable which will be used to calculate the test score
            //We set up all answers.isCorrect to false, so they can later be checked against the correct answers from testModel
            SetupQuestionList();

            //This variable is used for question navigation purposes
            currentQuestion = 0;

            //This method is used for loading individual questions
            PopulateQuestionGroupBox();
        }

        private void SetupQuestionList()
        {
            
            submitQuestionList = new List<QuestionModel>();

            foreach(QuestionModel question in testModel.QuestionList)
            {
                QuestionModel submitQuestion = new QuestionModel(question);
                foreach(AnswerModel answer in question.AnswerList)
                {
                    AnswerModel submitAnswer = new AnswerModel(answer);
                    submitQuestion.AnswerList.Add(submitAnswer);
                }
                submitQuestionList.Add(submitQuestion);
            }
        }
        private void ClearQuestionGroupBox()
        {
            foreach  (RadioButton answerBtn in answerButtonList)
            {
                questionBox.Controls.Remove(answerBtn);
            }
            answerButtonList = new List<RadioButton>();
            
        }

        private void PopulateQuestionGroupBox()
        {
            QuestionModel question = submitQuestionList.ElementAt(currentQuestion);
            questionBox.Text = question.QuestionText;

            //for (int i = 0; i < question.AnswerList.Count; i++)
            //{
            //    RadioButton answerBtn = new RadioButton();
            //    answerBtn.Checked = question.AnswerList.ElementAt(i).isChosen;
            //    questionBox.Controls.Add(answerBtn);
            //    answerButtonList.Add(answerBtn);

            //    //Drawing the radio button
            //    answerBtn.Location = new Point(25, 40 * (i + 1));
            //    answerBtn.Size = new Size(500, 25);
            //    answerBtn.Text = question.AnswerList.ElementAt(i).AnswerText;
            //}
            GenerateAnswers(question);
        }

		private void GenerateAnswers(QuestionModel question)
		{
			// Calculate available width for answers
			int availableWidth = questionBox.Width - 40 - 30; // Left margin + Right margin

			// Generate answer options dynamically
			for (int i = 0; i < question.AnswerList.Count; i++)
			{
				int fontSize = 10;
				Font answerFont = new Font("Segoe UI", fontSize, FontStyle.Regular);

				RadioButton rbCorrectAnswer = new RadioButton
				{
					Name = $"rbCorrectAnswer{i}",
					Location = new Point(100, 100 + i * 50),
					Text = $"{question.AnswerList.ElementAt(i).AnswerText}",
					Checked = false,
                    Font = answerFont,
                    AutoSize = true
				};
                answerButtonList.Add(rbCorrectAnswer);
				questionBox.Controls.Add(rbCorrectAnswer);
			}

		}



		private async void submitTestBtn_Click(object sender, EventArgs e)
        {
            
            SaveAnswerToSubmit();

            foreach (QuestionModel question in submitQuestionList)
            {
                if(!question.AnswerList.Any(a => a.isChosen))
                {
                    MessageBox.Show("You must select an answer for all questions");
                    return;
                }
            }

            testModel.Score = CalculateScore();
            testModel.UserName = Session.GetInstance().currentUser;

            try
            {
                int testScoreId = await APICalls.CreateTestScore(testModel);
				//DialogResult result = MessageBox.Show($"Your score is {testModel.Score} on '{testModel.TestName}' test");

				//if (result == DialogResult.OK) 
				//{
				//    this.Close();
				//}
				FinishedTestForm finishedTest = new FinishedTestForm(testModel);
				finishedTest.TestCompleted += CloseTakeTestForm;
				finishedTest.Show();
                this.Hide();
				// Show the FinishedTest form
				return;
            }
            catch (Exception except)
            {

                MessageBox.Show(except.Message);
                return;
            }

        }
		private void CloseTakeTestForm(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SaveAnswerToSubmit()
        {
            for (int i = 0; i < answerButtonList.Count; i++)
            {
                submitQuestionList
                    .ElementAt(currentQuestion)
                    .AnswerList.ElementAt(i)
                    .isChosen = answerButtonList.ElementAt(i).Checked;
            }
        }

        private int CalculateScore()
        {
            int score = 0;
            for (int i = 0; i < submitQuestionList.Count; i++)
            {
                QuestionModel question = submitQuestionList.ElementAt(i);

                for (int j = 0; j < question.AnswerList.Count; j++)
                {
                    AnswerModel chosenAnswer = question.AnswerList.ElementAt(j);
                    if (chosenAnswer.isChosen)
                    {
                        //if (testModel.QuestionList.ElementAt(i).AnswerList.ElementAt(j).isCorrect)
                        //{
                        //    score += 1;
                        //}
                        //else
                        //{
                        //    score -= 1;
                        //}
                        
                        score += testModel.QuestionList.ElementAt(i).CorrectAnswer == chosenAnswer ? 1 : -1;

                    }
                }
            }


            return score < 0 ? 0 : score;
               
        }


        private async void TakeTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.GetInstance().mainMenu.Show();
            await Session.GetInstance().mainMenu.PopulateTestListBoxAsync();
        }


        #region Question navigation
        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            //Enable previous button for navigation
            previousBtnQuestion.Enabled = true;

            //Save answers to be submitted later
            SaveAnswerToSubmit();


            currentQuestion += 1;
            ClearQuestionGroupBox();
            PopulateQuestionGroupBox();
            if(currentQuestion >= submitQuestionList.Count - 1)
            {
                nextQuestionBtn.Enabled = false;
            }
        }

        

        private void previousBtnQuestion_Click(object sender, EventArgs e)
        {
            nextQuestionBtn.Enabled = true;

            //Save answers to be submitted later
            SaveAnswerToSubmit();

            currentQuestion -= 1;
            ClearQuestionGroupBox();
            PopulateQuestionGroupBox();
            if (currentQuestion <= 0)
            {
                previousBtnQuestion.Enabled = false;
            }
        }
        #endregion

        //private void PopulateTestArea()
        //{
        //    //foreach(QuestionModel question in testModel.QuestionList)
        //    //{
        //    for (int i = 0; i < testModel.QuestionList.Count; i++)
        //    {
        //        QuestionModel question = testModel.QuestionList.ElementAt(i);

        //        GroupBox questionBox = new GroupBox();
        //        questionGroupBoxList.Add(questionBox);
        //        panel1.Controls.Add(questionBox);


        //        questionBox.Location = new Point(0, 400*i);
        //        questionBox.Size = new Size(500, question.AnswerList.Count * 50 + 100);
        //        questionBox.Text = question.QuestionText;

        //        foreach (AnswerModel answer in question.AnswerList)
        //        {

        //        }
        //    }

        //    //}
        //}
    }
}
