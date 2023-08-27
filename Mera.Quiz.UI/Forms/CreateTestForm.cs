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
	public partial class CreateTestForm : Form
	{
		private List<QuestionModel> questionList;
		private List<TextBox> answerTextList;
		private List<RadioButton> correctAnswerList;
		private List<Label> answerLabelList;
		private TestModel testModel;
		private bool validQuestionCheck;

		public CreateTestForm()
		{
			InitializeComponent();
			questionList = new List<QuestionModel>();
			answerTextList = new List<TextBox>();
			correctAnswerList = new List<RadioButton>();
			answerLabelList = new List<Label>();
			testModel = null;
			QuestionListBox.DataSource = questionList;

			answerTextList.Add(this.answerTxt1);
			answerTextList.Add(this.answerTxt2);
			answerTextList.Add(this.answerTxt3);
			answerTextList.Add(this.answerTxt4);
			answerTextList.Add(this.answerTxt5);


			correctAnswerList.Add(this.correctAnswer1);
			correctAnswerList.Add(this.correctAnswer2);
			correctAnswerList.Add(this.correctAnswer3);
			correctAnswerList.Add(this.correctAnswer4);
			correctAnswerList.Add(this.correctAnswer5);


			answerLabelList.Add(this.answerLbl1);
			answerLabelList.Add(this.answerLbl2);
			answerLabelList.Add(this.answerLbl3);
			answerLabelList.Add(this.answerLbl4);
			answerLabelList.Add(this.answerLbl5);


		}

		public CreateTestForm(object selectedItem)
		{
			//Convert selected test to TestModel
			testModel = (TestModel)selectedItem;

			InitializeComponent();
			answerTextList = new List<TextBox>();
			correctAnswerList = new List<RadioButton>();
			answerLabelList = new List<Label>();

			answerTextList.Add(this.answerTxt1);
			answerTextList.Add(this.answerTxt2);
			answerTextList.Add(this.answerTxt3);
			answerTextList.Add(this.answerTxt4);
			answerTextList.Add(this.answerTxt5);


			correctAnswerList.Add(this.correctAnswer1);
			correctAnswerList.Add(this.correctAnswer2);
			correctAnswerList.Add(this.correctAnswer3);
			correctAnswerList.Add(this.correctAnswer4);
			correctAnswerList.Add(this.correctAnswer5);


			answerLabelList.Add(this.answerLbl1);
			answerLabelList.Add(this.answerLbl2);
			answerLabelList.Add(this.answerLbl3);
			answerLabelList.Add(this.answerLbl4);
			answerLabelList.Add(this.answerLbl5);

			testNameTxt.Text = testModel.TestName;
			questionList = testModel.QuestionList;
			QuestionListBox.DataSource = questionList;
		}

		



		private async Task<bool> ValidateAndSaveQuestion()
		{
			validQuestionCheck = true;

			QuestionModel question = new QuestionModel();
			question.QuestionText = questionTxt.Text;
			question.AnswerList = new List<AnswerModel>();

			//Going through all answers to add them to the question
			for (int i = 0; i < answerTextList.Count; i++)
			{
				AnswerModel answer = new AnswerModel();
				string answerText = answerTextList.ElementAt(i).Text.Trim();

				if (String.IsNullOrEmpty(answerText))
				{
					continue;
				}
				answer.AnswerText = answerText;

				RadioButton correctAnswer = correctAnswerList.ElementAt(i);
				if (correctAnswer.Checked)
				{
					question.CorrectAnswer = answer;
				}

				question.AnswerList.Add(answer);

			}

			if (await ValidateQuestionAsync(question))
			{
				if (QuestionListBox.SelectedItem != null)
				{
					QuestionModel oldQuestion = (QuestionModel)QuestionListBox.SelectedItem;
					oldQuestion.AnswerList = question.AnswerList;
					oldQuestion.QuestionText = question.QuestionText;
				}
				else
				{
					questionList.Add(question);
				}


				QuestionListBox.DataSource = null;
				QuestionListBox.DataSource = questionList;
				QuestionListBox.ClearSelected();
				ResetCreateTestForm();

			}
			else
			{
				MessageBox.Show("Not valid question");
				validQuestionCheck = false;
			}
			return validQuestionCheck;
		}


		private async void newQuestionBtn_ClickAsync(object sender, EventArgs e)
		{
			await ValidateAndSaveQuestion();
		}

		private void ResetCreateTestForm()
		{
			questionTxt.Text = "";
			answerTxt1.Text = "";
			correctAnswer1.Checked = false;
			for (int i = answerTextList.Count - 1; i > 0; i--)
			{
				RemoveFromForm(i);
			}
		}

		private void RemoveFromForm(int position)
		{
			answerTextList.ElementAt(position).Text = "";
			correctAnswerList.ElementAt(position).Checked = false;
		}

		private async Task<bool> ValidateQuestionAsync(QuestionModel question)
		{
			try
			{
				QuestionModel validatedQuestion = await APICalls.ValidateQuestion(question);

				return true;
			}
			catch (Exception except)
			{

				return false;
			}
		}



		private async void saveTestBtn_ClickAsync(object sender, EventArgs e)
		{
			if (!await ValidateAndSaveQuestion())
			{
				DialogResult dialogResult = MessageBox.Show("The last question in the form was not valid. Do you want to skip it and save the test anyway?", "Save test?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No)
				{
					return;
				}
				
			}

			if (testModel == null)
			{
				TestModel test = new TestModel();
				test.TestName = testNameTxt.Text;
				test.QuestionList = questionList;
				try
				{
					TestModel createdTest = await APICalls.CreateTest(test);
					this.Close();
				}
				catch (Exception except)
				{
					MessageBox.Show(except.Message);
				}
			}
			else
			{
				testModel.TestName = testNameTxt.Text;
				testModel.QuestionList = questionList;

				try
				{
					TestModel createdTest = await APICalls.UpdateTest(testModel);

					this.Close();
				}
				catch (Exception except)
				{

					MessageBox.Show(except.Message);
				}
			}

		}

		private void QuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.QuestionListBox.SelectedItem != null)
			{
				deleteQuestionBtn.Enabled = true;
				PopulateQuestionForm(QuestionListBox.SelectedItem);
			}
			else
			{
				deleteQuestionBtn.Enabled = false;
			}
		}

		private void PopulateQuestionForm(object selectedItem)
		{
			QuestionModel question = (QuestionModel)selectedItem;

			//Resetting the form so we can populate it with the selected question
			ResetCreateTestForm();


			//Setting initial form components
			questionTxt.Text = question.QuestionText;

			//Setting dynamically added components
			for (int i = 0; i < question.AnswerList.Count; i++)
			{
				answerTextList.ElementAt(i).Text = question.AnswerList.ElementAt(i).AnswerText;
				correctAnswerList.ElementAt(i).Checked = question.AnswerList.ElementAt(i) == question.CorrectAnswer;
			}
		}

		private void deleteQuestionBtn_Click(object sender, EventArgs e)
		{
			if (QuestionListBox.SelectedItem != null)
			{
				QuestionModel question = (QuestionModel)QuestionListBox.SelectedItem;
				questionList.Remove(question);
				QuestionListBox.DataSource = null;
				QuestionListBox.DataSource = questionList;
				ResetCreateTestForm();
			}
		}

		private async void CreateTestForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Session.GetInstance().mainMenu.Show();
			await Session.GetInstance().mainMenu.PopulateTestListBoxAsync();
		}
	}
}
