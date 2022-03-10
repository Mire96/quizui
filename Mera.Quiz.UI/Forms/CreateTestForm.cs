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

        public CreateTestForm()
        {
            InitializeComponent();
            questionList = new List<QuestionModel>();
            answerTextList = new List<TextBox>();
            correctAnswerList = new List<RadioButton>();
            answerLabelList = new List<Label>();

            answerTextList.Add(this.answerTxt1);
            correctAnswerList.Add(this.correctAnswer1);
            answerLabelList.Add(this.answerLbl1);
        }

        private void addAnswerBtn_Click(object sender, EventArgs e)
        {
            this.answerNumber += 1;
            AddAnswerLabelDynamically();
            AddAnswerTextBoxDynamically();
            AddAnswerRadioButtonDynamically();
            
            
        }

        private void AddAnswerRadioButtonDynamically()
        {
            RadioButton newAnswerRadioButton = new RadioButton() { Text = "", Name = $"correctAnswer{answerNumber}" };
            correctAnswerList.Add(newAnswerRadioButton);
            this.panel1.Controls.Add(newAnswerRadioButton);
            newAnswerRadioButton.Location = new Point(499, (175 + answerNumber * 30));
        }

        private void AddAnswerTextBoxDynamically()
        {
            TextBox newAnswerBox = new TextBox() { Text = "", Name = $"answerTxt{answerNumber}" };
            answerTextList.Add(newAnswerBox);
            this.panel1.Controls.Add(newAnswerBox);

            newAnswerBox.Size = new Size(260, 27);
            newAnswerBox.Location = new Point(220, (170 + answerNumber * 30));
        }

        private void AddAnswerLabelDynamically()
        {
            Label newAnswerLabel = new Label() { Text = $"Answer{answerNumber}" };
            answerLabelList.Add(newAnswerLabel);
            this.panel1.Controls.Add(newAnswerLabel);
            newAnswerLabel.Location = new Point(118, (175 + answerNumber * 30));
        }

        private async void newQuestionBtn_ClickAsync(object sender, EventArgs e)
        {
            /*Code Snippet for getting radio button answers
            //All fields accessed this way must be PUBLIC!
            -------------------------------------------------
            System.Windows.Forms.RadioButton answer = this.GetType().GetField("Answerbtn1").GetValue(this) as System.Windows.Forms.RadioButton;
            Submitbtn.Text = answer.Text;
            -------------------------------------------------
             */


            //Creating question out of question text
            QuestionModel question = new QuestionModel() 
            { QuestionText = questionTxt.Text, AnswerList = new List<AnswerModel>() };

            //Going through all answers to add them to the question
            for (int i = 0; i < answerNumber; i++)
            {
                AnswerModel answer = new AnswerModel();
                TextBox answerText = answerTextList.ElementAt(i);
                answer.AnswerText = answerText.Text;

                RadioButton correctAnswer = correctAnswerList.ElementAt(i);
                answer.isCorrect = correctAnswer.Checked;

                question.AnswerList.Add(answer);

            }
            
            if (!await ValidateQuestionAsync(question))
            {
                ResetCreateTestForm();
            }


        }

        private void ResetCreateTestForm()
        {
            throw new NotImplementedException();
        }

        private async Task<bool> ValidateQuestionAsync(QuestionModel question)
        {
            try
            {
                QuestionModel validatedQuestion = await APICalls.ValidateQuestion(question);
                questionList.Add(validatedQuestion);
                return true;
            }
            catch (Exception except)
            {

                return false;
            }
        }

        private void removeAnswerBtn_Click(object sender, EventArgs e)
        {
            if(answerNumber <= 1)
            {
                MessageBox.Show("You can't remove all answers!");
                return;
            }
            answerNumber -= 1;
            int position = answerNumber;
            panel1.Controls.Remove(answerTextList.ElementAt(position));
            panel1.Controls.Remove(answerLabelList.ElementAt(position));
            panel1.Controls.Remove(correctAnswerList.ElementAt(position));

            answerTextList.RemoveAt(position);
            answerLabelList.RemoveAt(position);
            correctAnswerList.RemoveAt(position);

        }
    }
}
