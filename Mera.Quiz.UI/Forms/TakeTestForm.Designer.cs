
using System.Windows.Forms;

namespace Mera.Quiz.UI.Forms
{
    partial class TakeTestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionBox = new System.Windows.Forms.GroupBox();
            this.submitTestBtn = new System.Windows.Forms.Button();
            this.nextQuestionBtn = new System.Windows.Forms.Button();
            this.previousBtnQuestion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.questionBox);
            this.panel1.Location = new System.Drawing.Point(73, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 432);
            this.panel1.TabIndex = 0;
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(32, 22);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(686, 396);
            this.questionBox.TabIndex = 0;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Sedište OPEK-a, zemalja izvoznica nafte, nalazi se u";
            // 
            // submitTestBtn
            // 
            this.submitTestBtn.Location = new System.Drawing.Point(833, 35);
            this.submitTestBtn.Name = "submitTestBtn";
            this.submitTestBtn.Size = new System.Drawing.Size(140, 55);
            this.submitTestBtn.TabIndex = 1;
            this.submitTestBtn.Text = "Submit Test";
            this.submitTestBtn.UseVisualStyleBackColor = true;
            this.submitTestBtn.Click += new System.EventHandler(this.submitTestBtn_Click);
            // 
            // nextQuestionBtn
            // 
            this.nextQuestionBtn.Location = new System.Drawing.Point(651, 482);
            this.nextQuestionBtn.Name = "nextQuestionBtn";
            this.nextQuestionBtn.Size = new System.Drawing.Size(140, 41);
            this.nextQuestionBtn.TabIndex = 2;
            this.nextQuestionBtn.Text = "Next question";
            this.nextQuestionBtn.UseVisualStyleBackColor = true;
            this.nextQuestionBtn.Click += new System.EventHandler(this.nextQuestionBtn_Click);
            // 
            // previousBtnQuestion
            // 
            this.previousBtnQuestion.Location = new System.Drawing.Point(105, 482);
            this.previousBtnQuestion.Name = "previousBtnQuestion";
            this.previousBtnQuestion.Size = new System.Drawing.Size(140, 41);
            this.previousBtnQuestion.TabIndex = 3;
            this.previousBtnQuestion.Text = "Previous question";
            this.previousBtnQuestion.UseVisualStyleBackColor = true;
            this.previousBtnQuestion.Click += new System.EventHandler(this.previousBtnQuestion_Click);
            // 
            // TakeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 549);
            this.Controls.Add(this.previousBtnQuestion);
            this.Controls.Add(this.nextQuestionBtn);
            this.Controls.Add(this.submitTestBtn);
            this.Controls.Add(this.panel1);
            this.Name = "TakeTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TakeTestForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submitTestBtn;
        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.Button nextQuestionBtn;
        private System.Windows.Forms.Button previousBtnQuestion;
    }
}