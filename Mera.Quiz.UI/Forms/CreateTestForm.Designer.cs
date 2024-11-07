
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
			saveTestBtn = new Button();
			panel1 = new Panel();
			correctAnswer5 = new RadioButton();
			answerTxt5 = new TextBox();
			answerLbl5 = new Label();
			correctAnswer4 = new RadioButton();
			answerTxt4 = new TextBox();
			answerLbl4 = new Label();
			correctAnswer3 = new RadioButton();
			answerTxt3 = new TextBox();
			answerLbl3 = new Label();
			correctAnswer2 = new RadioButton();
			answerTxt2 = new TextBox();
			answerLbl2 = new Label();
			correctAnswer1 = new RadioButton();
			answerTxt1 = new TextBox();
			answerLbl1 = new Label();
			label1 = new Label();
			questionTxt = new RichTextBox();
			testNameLbl = new Label();
			testNameTxt = new TextBox();
			QuestionListBox = new ListBox();
			deleteQuestionBtn = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// newQuestionBtn
			// 
			newQuestionBtn.Location = new System.Drawing.Point(1311, 36);
			newQuestionBtn.Margin = new Padding(5, 5, 5, 5);
			newQuestionBtn.Name = "newQuestionBtn";
			newQuestionBtn.Size = new System.Drawing.Size(318, 101);
			newQuestionBtn.TabIndex = 0;
			newQuestionBtn.Text = "New Question";
			newQuestionBtn.UseVisualStyleBackColor = true;
			newQuestionBtn.Click += newQuestionBtn_ClickAsync;
			// 
			// saveTestBtn
			// 
			saveTestBtn.Location = new System.Drawing.Point(1331, 1202);
			saveTestBtn.Margin = new Padding(5, 5, 5, 5);
			saveTestBtn.Name = "saveTestBtn";
			saveTestBtn.Size = new System.Drawing.Size(260, 101);
			saveTestBtn.TabIndex = 2;
			saveTestBtn.Text = "Save test";
			saveTestBtn.UseVisualStyleBackColor = true;
			saveTestBtn.Click += saveTestBtn_ClickAsync;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.Controls.Add(correctAnswer5);
			panel1.Controls.Add(answerTxt5);
			panel1.Controls.Add(answerLbl5);
			panel1.Controls.Add(correctAnswer4);
			panel1.Controls.Add(answerTxt4);
			panel1.Controls.Add(answerLbl4);
			panel1.Controls.Add(correctAnswer3);
			panel1.Controls.Add(answerTxt3);
			panel1.Controls.Add(answerLbl3);
			panel1.Controls.Add(correctAnswer2);
			panel1.Controls.Add(answerTxt2);
			panel1.Controls.Add(answerLbl2);
			panel1.Controls.Add(correctAnswer1);
			panel1.Controls.Add(answerTxt1);
			panel1.Controls.Add(answerLbl1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(questionTxt);
			panel1.Location = new System.Drawing.Point(107, 210);
			panel1.Margin = new Padding(5, 5, 5, 5);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(1098, 1011);
			panel1.TabIndex = 3;
			// 
			// correctAnswer5
			// 
			correctAnswer5.AutoSize = true;
			correctAnswer5.Location = new System.Drawing.Point(725, 725);
			correctAnswer5.Margin = new Padding(5, 5, 5, 5);
			correctAnswer5.Name = "correctAnswer5";
			correctAnswer5.Size = new System.Drawing.Size(33, 32);
			correctAnswer5.TabIndex = 20;
			correctAnswer5.TabStop = true;
			correctAnswer5.UseVisualStyleBackColor = true;
			// 
			// answerTxt5
			// 
			answerTxt5.Location = new System.Drawing.Point(135, 714);
			answerTxt5.Margin = new Padding(5, 5, 5, 5);
			answerTxt5.Name = "answerTxt5";
			answerTxt5.Size = new System.Drawing.Size(548, 47);
			answerTxt5.TabIndex = 18;
			// 
			// answerLbl5
			// 
			answerLbl5.AutoSize = true;
			answerLbl5.Location = new System.Drawing.Point(62, 717);
			answerLbl5.Margin = new Padding(5, 0, 5, 0);
			answerLbl5.Name = "answerLbl5";
			answerLbl5.Size = new System.Drawing.Size(41, 41);
			answerLbl5.TabIndex = 19;
			answerLbl5.Text = "5.";
			// 
			// correctAnswer4
			// 
			correctAnswer4.AutoSize = true;
			correctAnswer4.Location = new System.Drawing.Point(725, 648);
			correctAnswer4.Margin = new Padding(5, 5, 5, 5);
			correctAnswer4.Name = "correctAnswer4";
			correctAnswer4.Size = new System.Drawing.Size(33, 32);
			correctAnswer4.TabIndex = 17;
			correctAnswer4.TabStop = true;
			correctAnswer4.UseVisualStyleBackColor = true;
			// 
			// answerTxt4
			// 
			answerTxt4.Location = new System.Drawing.Point(135, 637);
			answerTxt4.Margin = new Padding(5, 5, 5, 5);
			answerTxt4.Name = "answerTxt4";
			answerTxt4.Size = new System.Drawing.Size(548, 47);
			answerTxt4.TabIndex = 15;
			// 
			// answerLbl4
			// 
			answerLbl4.AutoSize = true;
			answerLbl4.Location = new System.Drawing.Point(62, 640);
			answerLbl4.Margin = new Padding(5, 0, 5, 0);
			answerLbl4.Name = "answerLbl4";
			answerLbl4.Size = new System.Drawing.Size(41, 41);
			answerLbl4.TabIndex = 16;
			answerLbl4.Text = "4.";
			// 
			// correctAnswer3
			// 
			correctAnswer3.AutoSize = true;
			correctAnswer3.Location = new System.Drawing.Point(725, 572);
			correctAnswer3.Margin = new Padding(5, 5, 5, 5);
			correctAnswer3.Name = "correctAnswer3";
			correctAnswer3.Size = new System.Drawing.Size(33, 32);
			correctAnswer3.TabIndex = 14;
			correctAnswer3.TabStop = true;
			correctAnswer3.UseVisualStyleBackColor = true;
			// 
			// answerTxt3
			// 
			answerTxt3.Location = new System.Drawing.Point(135, 561);
			answerTxt3.Margin = new Padding(5, 5, 5, 5);
			answerTxt3.Name = "answerTxt3";
			answerTxt3.Size = new System.Drawing.Size(548, 47);
			answerTxt3.TabIndex = 12;
			// 
			// answerLbl3
			// 
			answerLbl3.AutoSize = true;
			answerLbl3.Location = new System.Drawing.Point(62, 566);
			answerLbl3.Margin = new Padding(5, 0, 5, 0);
			answerLbl3.Name = "answerLbl3";
			answerLbl3.Size = new System.Drawing.Size(41, 41);
			answerLbl3.TabIndex = 13;
			answerLbl3.Text = "3.";
			// 
			// correctAnswer2
			// 
			correctAnswer2.AutoSize = true;
			correctAnswer2.Location = new System.Drawing.Point(725, 501);
			correctAnswer2.Margin = new Padding(5, 5, 5, 5);
			correctAnswer2.Name = "correctAnswer2";
			correctAnswer2.Size = new System.Drawing.Size(33, 32);
			correctAnswer2.TabIndex = 11;
			correctAnswer2.TabStop = true;
			correctAnswer2.UseVisualStyleBackColor = true;
			// 
			// answerTxt2
			// 
			answerTxt2.Location = new System.Drawing.Point(135, 490);
			answerTxt2.Margin = new Padding(5, 5, 5, 5);
			answerTxt2.Name = "answerTxt2";
			answerTxt2.Size = new System.Drawing.Size(548, 47);
			answerTxt2.TabIndex = 9;
			// 
			// answerLbl2
			// 
			answerLbl2.AutoSize = true;
			answerLbl2.Location = new System.Drawing.Point(62, 493);
			answerLbl2.Margin = new Padding(5, 0, 5, 0);
			answerLbl2.Name = "answerLbl2";
			answerLbl2.Size = new System.Drawing.Size(41, 41);
			answerLbl2.TabIndex = 10;
			answerLbl2.Text = "2.";
			// 
			// correctAnswer1
			// 
			correctAnswer1.AutoSize = true;
			correctAnswer1.Location = new System.Drawing.Point(725, 427);
			correctAnswer1.Margin = new Padding(5, 5, 5, 5);
			correctAnswer1.Name = "correctAnswer1";
			correctAnswer1.Size = new System.Drawing.Size(33, 32);
			correctAnswer1.TabIndex = 8;
			correctAnswer1.TabStop = true;
			correctAnswer1.UseVisualStyleBackColor = true;
			// 
			// answerTxt1
			// 
			answerTxt1.Location = new System.Drawing.Point(135, 416);
			answerTxt1.Margin = new Padding(5, 5, 5, 5);
			answerTxt1.Name = "answerTxt1";
			answerTxt1.Size = new System.Drawing.Size(548, 47);
			answerTxt1.TabIndex = 6;
			// 
			// answerLbl1
			// 
			answerLbl1.AutoSize = true;
			answerLbl1.Location = new System.Drawing.Point(62, 419);
			answerLbl1.Margin = new Padding(5, 0, 5, 0);
			answerLbl1.Name = "answerLbl1";
			answerLbl1.Size = new System.Drawing.Size(41, 41);
			answerLbl1.TabIndex = 7;
			answerLbl1.Text = "1.";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(62, 40);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(215, 41);
			label1.TabIndex = 6;
			label1.Text = "Question Text: ";
			// 
			// questionTxt
			// 
			questionTxt.Location = new System.Drawing.Point(130, 104);
			questionTxt.Margin = new Padding(5, 5, 5, 5);
			questionTxt.Name = "questionTxt";
			questionTxt.Size = new System.Drawing.Size(934, 266);
			questionTxt.TabIndex = 0;
			questionTxt.Text = "";
			// 
			// testNameLbl
			// 
			testNameLbl.AutoSize = true;
			testNameLbl.Location = new System.Drawing.Point(60, 57);
			testNameLbl.Margin = new Padding(5, 0, 5, 0);
			testNameLbl.Name = "testNameLbl";
			testNameLbl.Size = new System.Drawing.Size(167, 41);
			testNameLbl.TabIndex = 4;
			testNameLbl.Text = "Test name: ";
			// 
			// testNameTxt
			// 
			testNameTxt.Location = new System.Drawing.Point(237, 57);
			testNameTxt.Margin = new Padding(5, 5, 5, 5);
			testNameTxt.Name = "testNameTxt";
			testNameTxt.Size = new System.Drawing.Size(281, 47);
			testNameTxt.TabIndex = 5;
			// 
			// QuestionListBox
			// 
			QuestionListBox.FormattingEnabled = true;
			QuestionListBox.ItemHeight = 41;
			QuestionListBox.Location = new System.Drawing.Point(1311, 369);
			QuestionListBox.Margin = new Padding(5, 5, 5, 5);
			QuestionListBox.Name = "QuestionListBox";
			QuestionListBox.Size = new System.Drawing.Size(315, 783);
			QuestionListBox.TabIndex = 7;
			QuestionListBox.SelectedIndexChanged += QuestionListBox_SelectedIndexChanged;
			// 
			// deleteQuestionBtn
			// 
			deleteQuestionBtn.Enabled = false;
			deleteQuestionBtn.Location = new System.Drawing.Point(1308, 210);
			deleteQuestionBtn.Margin = new Padding(5, 5, 5, 5);
			deleteQuestionBtn.Name = "deleteQuestionBtn";
			deleteQuestionBtn.Size = new System.Drawing.Size(318, 101);
			deleteQuestionBtn.TabIndex = 8;
			deleteQuestionBtn.Text = "Delete Question";
			deleteQuestionBtn.UseVisualStyleBackColor = true;
			deleteQuestionBtn.Click += deleteQuestionBtn_Click;
			// 
			// CreateTestForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1697, 1421);
			Controls.Add(deleteQuestionBtn);
			Controls.Add(QuestionListBox);
			Controls.Add(testNameTxt);
			Controls.Add(testNameLbl);
			Controls.Add(panel1);
			Controls.Add(saveTestBtn);
			Controls.Add(newQuestionBtn);
			Margin = new Padding(5, 5, 5, 5);
			Name = "CreateTestForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CreateTestForm";
			FormClosed += CreateTestForm_FormClosed;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button newQuestionBtn;
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
		private ListBox QuestionListBox;
		private Button deleteQuestionBtn;
		private RadioButton correctAnswer5;
		private TextBox answerTxt5;
		private Label answerLbl5;
		private RadioButton correctAnswer4;
		private TextBox answerTxt4;
		private Label answerLbl4;
		private RadioButton correctAnswer3;
		private TextBox answerTxt3;
		private Label answerLbl3;
		private RadioButton correctAnswer2;
		private TextBox answerTxt2;
		private Label answerLbl2;
	}
}