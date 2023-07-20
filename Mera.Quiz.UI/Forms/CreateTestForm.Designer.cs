
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mera.Quiz.UI.Forms
{
	partial class CreateTestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			newQuestionBtn = new Button();
			addAnswerBtn = new Button();
			saveTestBtn = new Button();
			panel1 = new Panel();
			dataGridView1 = new DataGridView();
			correctAnswer1 = new RadioButton();
			answerTxt1 = new TextBox();
			answerLbl1 = new Label();
			label1 = new Label();
			questionTxt = new RichTextBox();
			testNameLbl = new Label();
			testNameTxt = new TextBox();
			removeAnswerBtn = new Button();
			QuestionListBox = new ListBox();
			deleteQuestionBtn = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// newQuestionBtn
			// 
			newQuestionBtn.Location = new System.Drawing.Point(1349, 35);
			newQuestionBtn.Margin = new Padding(6);
			newQuestionBtn.Name = "newQuestionBtn";
			newQuestionBtn.Size = new System.Drawing.Size(259, 100);
			newQuestionBtn.TabIndex = 0;
			newQuestionBtn.Text = "New Question";
			newQuestionBtn.UseVisualStyleBackColor = true;
			newQuestionBtn.Click += newQuestionBtn_ClickAsync;
			// 
			// addAnswerBtn
			// 
			addAnswerBtn.Location = new System.Drawing.Point(357, 1267);
			addAnswerBtn.Margin = new Padding(6);
			addAnswerBtn.Name = "addAnswerBtn";
			addAnswerBtn.Size = new System.Drawing.Size(259, 100);
			addAnswerBtn.TabIndex = 1;
			addAnswerBtn.Text = "Add answer";
			addAnswerBtn.UseVisualStyleBackColor = true;
			addAnswerBtn.Click += addAnswerBtn_Click;
			// 
			// saveTestBtn
			// 
			saveTestBtn.Location = new System.Drawing.Point(1766, 1267);
			saveTestBtn.Margin = new Padding(6);
			saveTestBtn.Name = "saveTestBtn";
			saveTestBtn.Size = new System.Drawing.Size(259, 100);
			saveTestBtn.TabIndex = 2;
			saveTestBtn.Text = "Save test";
			saveTestBtn.UseVisualStyleBackColor = true;
			saveTestBtn.Click += saveTestBtn_ClickAsync;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.Controls.Add(dataGridView1);
			panel1.Controls.Add(correctAnswer1);
			panel1.Controls.Add(answerTxt1);
			panel1.Controls.Add(answerLbl1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(questionTxt);
			panel1.Location = new System.Drawing.Point(106, 211);
			panel1.Margin = new Padding(6);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(1502, 1011);
			panel1.TabIndex = 3;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new System.Drawing.Point(443, 514);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 102;
			dataGridView1.RowTemplate.Height = 49;
			dataGridView1.Size = new System.Drawing.Size(953, 375);
			dataGridView1.TabIndex = 9;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			dataGridView1.GridColor = Color.White;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.DataSource = answers;
			dataGridView1.CellContentClick += OnCellContentClicked;

			// 
			// correctAnswer1
			// 
			correctAnswer1.AutoSize = true;
			correctAnswer1.Location = new System.Drawing.Point(1060, 420);
			correctAnswer1.Margin = new Padding(6);
			correctAnswer1.Name = "correctAnswer1";
			correctAnswer1.Size = new System.Drawing.Size(33, 32);
			correctAnswer1.TabIndex = 8;
			correctAnswer1.TabStop = true;
			correctAnswer1.UseVisualStyleBackColor = true;
			// 
			// answerTxt1
			// 
			answerTxt1.Location = new System.Drawing.Point(468, 410);
			answerTxt1.Margin = new Padding(6);
			answerTxt1.Name = "answerTxt1";
			answerTxt1.Size = new System.Drawing.Size(548, 47);
			answerTxt1.TabIndex = 6;
			// 
			// answerLbl1
			// 
			answerLbl1.AutoSize = true;
			answerLbl1.Location = new System.Drawing.Point(251, 420);
			answerLbl1.Margin = new Padding(6, 0, 6, 0);
			answerLbl1.Name = "answerLbl1";
			answerLbl1.Size = new System.Drawing.Size(139, 41);
			answerLbl1.TabIndex = 7;
			answerLbl1.Text = "Answer1 ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(172, 105);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(215, 41);
			label1.TabIndex = 6;
			label1.Text = "Question Text: ";
			// 
			// questionTxt
			// 
			questionTxt.Location = new System.Drawing.Point(463, 98);
			questionTxt.Margin = new Padding(6);
			questionTxt.Name = "questionTxt";
			questionTxt.Size = new System.Drawing.Size(933, 266);
			questionTxt.TabIndex = 0;
			questionTxt.Text = "";
			// 
			// testNameLbl
			// 
			testNameLbl.AutoSize = true;
			testNameLbl.Location = new System.Drawing.Point(138, 64);
			testNameLbl.Margin = new Padding(6, 0, 6, 0);
			testNameLbl.Name = "testNameLbl";
			testNameLbl.Size = new System.Drawing.Size(167, 41);
			testNameLbl.TabIndex = 4;
			testNameLbl.Text = "Test name: ";
			// 
			// testNameTxt
			// 
			testNameTxt.Location = new System.Drawing.Point(327, 57);
			testNameTxt.Margin = new Padding(6);
			testNameTxt.Name = "testNameTxt";
			testNameTxt.Size = new System.Drawing.Size(280, 47);
			testNameTxt.TabIndex = 5;
			// 
			// removeAnswerBtn
			// 
			removeAnswerBtn.Enabled = false;
			removeAnswerBtn.Location = new System.Drawing.Point(684, 1267);
			removeAnswerBtn.Margin = new Padding(6);
			removeAnswerBtn.Name = "removeAnswerBtn";
			removeAnswerBtn.Size = new System.Drawing.Size(259, 100);
			removeAnswerBtn.TabIndex = 6;
			removeAnswerBtn.Text = "Remove answer";
			removeAnswerBtn.UseVisualStyleBackColor = true;
			removeAnswerBtn.Click += removeAnswerBtn_Click;
			// 
			// QuestionListBox
			// 
			QuestionListBox.FormattingEnabled = true;
			QuestionListBox.ItemHeight = 41;
			QuestionListBox.Location = new System.Drawing.Point(1745, 435);
			QuestionListBox.Margin = new Padding(6);
			QuestionListBox.Name = "QuestionListBox";
			QuestionListBox.Size = new System.Drawing.Size(314, 783);
			QuestionListBox.TabIndex = 7;
			QuestionListBox.SelectedIndexChanged += QuestionListBox_SelectedIndexChanged;
			// 
			// deleteQuestionBtn
			// 
			deleteQuestionBtn.Enabled = false;
			deleteQuestionBtn.Location = new System.Drawing.Point(1745, 287);
			deleteQuestionBtn.Margin = new Padding(6);
			deleteQuestionBtn.Name = "deleteQuestionBtn";
			deleteQuestionBtn.Size = new System.Drawing.Size(319, 100);
			deleteQuestionBtn.TabIndex = 8;
			deleteQuestionBtn.Text = "Delete Question";
			deleteQuestionBtn.UseVisualStyleBackColor = true;
			deleteQuestionBtn.Click += deleteQuestionBtn_Click;
			// 
			// CreateTestForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(2127, 1421);
			Controls.Add(deleteQuestionBtn);
			Controls.Add(QuestionListBox);
			Controls.Add(removeAnswerBtn);
			Controls.Add(testNameTxt);
			Controls.Add(testNameLbl);
			Controls.Add(panel1);
			Controls.Add(saveTestBtn);
			Controls.Add(addAnswerBtn);
			Controls.Add(newQuestionBtn);
			Margin = new Padding(6);
			Name = "CreateTestForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CreateTestForm";
			FormClosed += CreateTestForm_FormClosed;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void OnCellContentClicked(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				for (var i = 0; i < dataGridView1.RowCount; i++)
				{
					var row = dataGridView1.Rows[i];
					row.Cells[e.ColumnIndex].Value = row.Selected;
				}
			}
		}

		private void OnDrawAnswer(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			Label newAnswerLabel = new Label() { Text = $"Answer{answerNumber}" };
		}

		#endregion

		private System.Windows.Forms.Button newQuestionBtn;
		private System.Windows.Forms.Button addAnswerBtn;
		private System.Windows.Forms.Button saveTestBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton correctAnswer1;
		private System.Windows.Forms.TextBox answerTxt1;
		private System.Windows.Forms.Label answerLbl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox questionTxt;
		private System.Windows.Forms.Label testNameLbl;
		private System.Windows.Forms.TextBox testNameTxt;
		private int answerNumber = 1;
		private int questionNumber = 1;
		private System.Windows.Forms.Button removeAnswerBtn;
		private ListBox QuestionListBox;
		private Button deleteQuestionBtn;
		private DataGridView dataGridView1;
	}
}