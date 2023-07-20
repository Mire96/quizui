using Mera.Quiz.UI.API_connection;
using Mera.Quiz.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		private BindingList<AnswerModel> answers;

		public CreateTestForm()
		{
			answers = new BindingList<AnswerModel>();
			InitializeComponent();
			questionList = new List<QuestionModel>();
			answerTextList = new List<TextBox>();
			correctAnswerList = new List<RadioButton>();
			answerLabelList = new List<Label>();
			testModel = null;
			QuestionListBox.DataSource = questionList;

			answerTextList.Add(this.answerTxt1);
			correctAnswerList.Add(this.correctAnswer1);
			answerLabelList.Add(this.answerLbl1);
		}

		public CreateTestForm(object selectedItem)
		{
			//Convert selected test to TestModel
			testModel = (TestModel)selectedItem;
			answers = new BindingList<AnswerModel>();

			InitializeComponent();
			questionList = new List<QuestionModel>();
			answerTextList = new List<TextBox>();
			correctAnswerList = new List<RadioButton>();
			answerLabelList = new List<Label>();

			answerTextList.Add(this.answerTxt1);
			correctAnswerList.Add(this.correctAnswer1);
			answerLabelList.Add(this.answerLbl1);

			testNameTxt.Text = testModel.TestName;
			questionList = testModel.QuestionList;
			QuestionListBox.DataSource = questionList;
		}

		private void addAnswerBtn_Click(object sender, EventArgs e)
		{
			answers.Add(new AnswerModel());
			//this.removeAnswerBtn.Enabled = true;
			//this.answerNumber += 1;

			//AddAnswerLabelDynamically();
			//AddAnswerTextBoxDynamically();
			//AddAnswerRadioButtonDynamically();
		}

		private void AddAnswerRadioButtonDynamically()
		{
			RadioButton newAnswerRadioButton = new RadioButton() { Text = "", Name = $"correctAnswer{answerNumber}" };
			correctAnswerList.Add(newAnswerRadioButton);
			this.panel1.Controls.Add(newAnswerRadioButton);
			newAnswerRadioButton.Location = new Point(correctAnswerList[0].Location.X, correctAnswerList[0].Location.Y + answerNumber * 60);
		}

		private void AddAnswerTextBoxDynamically()
		{
			TextBox newAnswerBox = new TextBox() { Text = "", Name = $"answerTxt{answerNumber}" };
			answerTextList.Add(newAnswerBox);
			this.panel1.Controls.Add(newAnswerBox);

			newAnswerBox.Size = answerTextList[0].Size;
			newAnswerBox.Location = new Point(answerTextList[0].Location.X, answerTextList[0].Location.Y + answerNumber * 60);
		}

		private void AddAnswerLabelDynamically()
		{
			Label newAnswerLabel = new Label() { Text = $"Answer{answerNumber}" };
			answerLabelList.Add(newAnswerLabel);
			this.panel1.Controls.Add(newAnswerLabel);
			newAnswerLabel.Location = new Point(answerLabelList[0].Location.X, answerLabelList[0].Location.Y + answerNumber * 60);
		}

		private async void newQuestionBtn_ClickAsync(object sender, EventArgs e)
		{
			validQuestionCheck = true;

			QuestionModel question = new QuestionModel();
			question.QuestionText = questionTxt.Text;
			//question.AnswerList = new List<AnswerModel>();
			question.AnswerList = answers.ToList();

			//Going through all answers to add them to the question
			//for (int i = 0; i < answerNumber; i++)
			//{
			//	AnswerModel answer = new AnswerModel();
			//	TextBox answerText = answerTextList.ElementAt(i);
			//	answer.AnswerText = answerText.Text;

			//	RadioButton correctAnswer = correctAnswerList.ElementAt(i);
			//	answer.isCorrect = correctAnswer.Checked;


			//	question.AnswerList.Add(answer);

			//}

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


		}

		private void ResetCreateTestForm()
		{
			questionTxt.Text = "";
			answerTxt1.Text = "";
			correctAnswer1.Checked = false;
			removeAnswerBtn.Enabled = false;
			for (int i = answerNumber - 1; i > 0; i--)
			{
				RemoveFromForm(i);
			}
			answerNumber = 1;
		}

		private void RemoveFromForm(int position)
		{
			panel1.Controls.Remove(answerTextList.ElementAt(position));
			panel1.Controls.Remove(answerLabelList.ElementAt(position));
			panel1.Controls.Remove(correctAnswerList.ElementAt(position));

			answerTextList.RemoveAt(position);
			answerLabelList.RemoveAt(position);
			correctAnswerList.RemoveAt(position);
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

		private void removeAnswerBtn_Click(object sender, EventArgs e)
		{

			answerNumber -= 1;
			int position = answerNumber;
			RemoveFromForm(position);
			if (answerNumber <= 1)
			{
				this.removeAnswerBtn.Enabled = false;
				return;
			}


		}


		private async void saveTestBtn_ClickAsync(object sender, EventArgs e)
		{

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

			//Setting answer number to the number of answers of newly selected question
			answerNumber = 1;

			//Setting initial form components
			questionTxt.Text = question.QuestionText;
			answerTxt1.Text = question.AnswerList.ElementAt(0).AnswerText;
			correctAnswer1.Checked = question.AnswerList.ElementAt(0).isCorrect;

			//Setting dynamically added components
			for (int i = 1; i < question.AnswerList.Count; i++)
			{
				answerNumber += 1;
				AddAnswerLabelDynamically();
				AddAnswerTextBoxDynamically();
				AddAnswerRadioButtonDynamically();
				answerTextList.ElementAt(i).Text = question.AnswerList.ElementAt(i).AnswerText;
				correctAnswerList.ElementAt(i).Checked = question.AnswerList.ElementAt(i).isCorrect;
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

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
