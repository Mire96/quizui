
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
            this.newQuestionBtn = new System.Windows.Forms.Button();
            this.addAnswerBtn = new System.Windows.Forms.Button();
            this.saveTestBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.correctAnswer1 = new System.Windows.Forms.RadioButton();
            this.answerTxt1 = new System.Windows.Forms.TextBox();
            this.answerLbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionTxt = new System.Windows.Forms.RichTextBox();
            this.testNameLbl = new System.Windows.Forms.Label();
            this.testNameTxt = new System.Windows.Forms.TextBox();
            this.removeAnswerBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newQuestionBtn
            // 
            this.newQuestionBtn.Location = new System.Drawing.Point(838, 103);
            this.newQuestionBtn.Name = "newQuestionBtn";
            this.newQuestionBtn.Size = new System.Drawing.Size(122, 49);
            this.newQuestionBtn.TabIndex = 0;
            this.newQuestionBtn.Text = "New Question";
            this.newQuestionBtn.UseVisualStyleBackColor = true;
            this.newQuestionBtn.Click += new System.EventHandler(this.newQuestionBtn_ClickAsync);
            // 
            // addAnswerBtn
            // 
            this.addAnswerBtn.Location = new System.Drawing.Point(838, 178);
            this.addAnswerBtn.Name = "addAnswerBtn";
            this.addAnswerBtn.Size = new System.Drawing.Size(122, 49);
            this.addAnswerBtn.TabIndex = 1;
            this.addAnswerBtn.Text = "Add answer";
            this.addAnswerBtn.UseVisualStyleBackColor = true;
            this.addAnswerBtn.Click += new System.EventHandler(this.addAnswerBtn_Click);
            // 
            // saveTestBtn
            // 
            this.saveTestBtn.Location = new System.Drawing.Point(838, 462);
            this.saveTestBtn.Name = "saveTestBtn";
            this.saveTestBtn.Size = new System.Drawing.Size(122, 49);
            this.saveTestBtn.TabIndex = 2;
            this.saveTestBtn.Text = "Save test";
            this.saveTestBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.correctAnswer1);
            this.panel1.Controls.Add(this.answerTxt1);
            this.panel1.Controls.Add(this.answerLbl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.questionTxt);
            this.panel1.Location = new System.Drawing.Point(50, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 493);
            this.panel1.TabIndex = 3;
            // 
            // correctAnswer1
            // 
            this.correctAnswer1.AutoSize = true;
            this.correctAnswer1.Location = new System.Drawing.Point(499, 205);
            this.correctAnswer1.Name = "correctAnswer1";
            this.correctAnswer1.Size = new System.Drawing.Size(17, 16);
            this.correctAnswer1.TabIndex = 8;
            this.correctAnswer1.TabStop = true;
            this.correctAnswer1.UseVisualStyleBackColor = true;
            // 
            // answerTxt1
            // 
            this.answerTxt1.Location = new System.Drawing.Point(220, 200);
            this.answerTxt1.Name = "answerTxt1";
            this.answerTxt1.Size = new System.Drawing.Size(260, 27);
            this.answerTxt1.TabIndex = 6;
            // 
            // answerLbl1
            // 
            this.answerLbl1.AutoSize = true;
            this.answerLbl1.Location = new System.Drawing.Point(118, 205);
            this.answerLbl1.Name = "answerLbl1";
            this.answerLbl1.Size = new System.Drawing.Size(69, 20);
            this.answerLbl1.TabIndex = 7;
            this.answerLbl1.Text = "Answer1 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question Text: ";
            // 
            // questionTxt
            // 
            this.questionTxt.Location = new System.Drawing.Point(218, 48);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Size = new System.Drawing.Size(441, 132);
            this.questionTxt.TabIndex = 0;
            this.questionTxt.Text = "";
            // 
            // testNameLbl
            // 
            this.testNameLbl.AutoSize = true;
            this.testNameLbl.Location = new System.Drawing.Point(65, 31);
            this.testNameLbl.Name = "testNameLbl";
            this.testNameLbl.Size = new System.Drawing.Size(83, 20);
            this.testNameLbl.TabIndex = 4;
            this.testNameLbl.Text = "Test name: ";
            // 
            // testNameTxt
            // 
            this.testNameTxt.Location = new System.Drawing.Point(154, 28);
            this.testNameTxt.Name = "testNameTxt";
            this.testNameTxt.Size = new System.Drawing.Size(134, 27);
            this.testNameTxt.TabIndex = 5;
            // 
            // removeAnswerBtn
            // 
            this.removeAnswerBtn.Location = new System.Drawing.Point(838, 254);
            this.removeAnswerBtn.Name = "removeAnswerBtn";
            this.removeAnswerBtn.Size = new System.Drawing.Size(122, 49);
            this.removeAnswerBtn.TabIndex = 6;
            this.removeAnswerBtn.Text = "Remove answer";
            this.removeAnswerBtn.UseVisualStyleBackColor = true;
            this.removeAnswerBtn.Click += new System.EventHandler(this.removeAnswerBtn_Click);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 631);
            this.Controls.Add(this.removeAnswerBtn);
            this.Controls.Add(this.testNameTxt);
            this.Controls.Add(this.testNameLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveTestBtn);
            this.Controls.Add(this.addAnswerBtn);
            this.Controls.Add(this.newQuestionBtn);
            this.Name = "CreateTestForm";
            this.Text = "CreateTestForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}