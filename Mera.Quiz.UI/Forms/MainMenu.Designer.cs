
namespace Mera.Quiz.UI.Forms
{
    partial class MainMenu
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
            this.takeTestBtn = new System.Windows.Forms.Button();
            this.addTestBtn = new System.Windows.Forms.Button();
            this.updateTestBtn = new System.Windows.Forms.Button();
            this.deleteTestBtn = new System.Windows.Forms.Button();
            this.testListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // takeTestBtn
            // 
            this.takeTestBtn.Location = new System.Drawing.Point(592, 80);
            this.takeTestBtn.Name = "takeTestBtn";
            this.takeTestBtn.Size = new System.Drawing.Size(93, 31);
            this.takeTestBtn.TabIndex = 0;
            this.takeTestBtn.Text = "Take test";
            this.takeTestBtn.UseVisualStyleBackColor = true;
            // 
            // addTestBtn
            // 
            this.addTestBtn.Location = new System.Drawing.Point(592, 153);
            this.addTestBtn.Name = "addTestBtn";
            this.addTestBtn.Size = new System.Drawing.Size(93, 31);
            this.addTestBtn.TabIndex = 1;
            this.addTestBtn.Text = "Add test";
            this.addTestBtn.UseVisualStyleBackColor = true;
            this.addTestBtn.Click += new System.EventHandler(this.addTestBtn_Click);
            // 
            // updateTestBtn
            // 
            this.updateTestBtn.Location = new System.Drawing.Point(592, 229);
            this.updateTestBtn.Name = "updateTestBtn";
            this.updateTestBtn.Size = new System.Drawing.Size(93, 31);
            this.updateTestBtn.TabIndex = 2;
            this.updateTestBtn.Text = "Update test";
            this.updateTestBtn.UseVisualStyleBackColor = true;
            // 
            // deleteTestBtn
            // 
            this.deleteTestBtn.Enabled = false;
            this.deleteTestBtn.Location = new System.Drawing.Point(592, 300);
            this.deleteTestBtn.Name = "deleteTestBtn";
            this.deleteTestBtn.Size = new System.Drawing.Size(93, 31);
            this.deleteTestBtn.TabIndex = 3;
            this.deleteTestBtn.Text = "Delete test";
            this.deleteTestBtn.UseVisualStyleBackColor = true;
            this.deleteTestBtn.Click += new System.EventHandler(this.deleteTestBtn_ClickAsync);
            // 
            // testListBox
            // 
            this.testListBox.FormattingEnabled = true;
            this.testListBox.ItemHeight = 20;
            this.testListBox.Location = new System.Drawing.Point(93, 64);
            this.testListBox.Name = "testListBox";
            this.testListBox.Size = new System.Drawing.Size(392, 284);
            this.testListBox.TabIndex = 4;
            this.testListBox.SelectedIndexChanged += new System.EventHandler(this.testListBox_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testListBox);
            this.Controls.Add(this.deleteTestBtn);
            this.Controls.Add(this.updateTestBtn);
            this.Controls.Add(this.addTestBtn);
            this.Controls.Add(this.takeTestBtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button takeTestBtn;
        private System.Windows.Forms.Button addTestBtn;
        private System.Windows.Forms.Button updateTestBtn;
        private System.Windows.Forms.Button deleteTestBtn;
        private System.Windows.Forms.ListBox testListBox;
    }
}