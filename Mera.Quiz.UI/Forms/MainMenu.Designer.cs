
using System.Windows.Forms;

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
			takeTestBtn = new Button();
			addTestBtn = new Button();
			updateTestBtn = new Button();
			deleteTestBtn = new Button();
			testListBox = new ListBox();
			viewTestResultsBtn = new Button();
			SuspendLayout();
			// 
			// takeTestBtn
			// 
			takeTestBtn.Location = new System.Drawing.Point(1099, 162);
			takeTestBtn.Margin = new Padding(6, 6, 6, 6);
			takeTestBtn.Name = "takeTestBtn";
			takeTestBtn.Size = new System.Drawing.Size(198, 64);
			takeTestBtn.TabIndex = 0;
			takeTestBtn.Text = "Take test";
			takeTestBtn.UseVisualStyleBackColor = true;
			takeTestBtn.Click += takeTestBtn_Click;
			// 
			// addTestBtn
			// 
			addTestBtn.Location = new System.Drawing.Point(1099, 312);
			addTestBtn.Margin = new Padding(6, 6, 6, 6);
			addTestBtn.Name = "addTestBtn";
			addTestBtn.Size = new System.Drawing.Size(198, 64);
			addTestBtn.TabIndex = 1;
			addTestBtn.Text = "Add test";
			addTestBtn.UseVisualStyleBackColor = true;
			addTestBtn.Click += addTestBtn_Click;
			// 
			// updateTestBtn
			// 
			updateTestBtn.Location = new System.Drawing.Point(1099, 467);
			updateTestBtn.Margin = new Padding(6, 6, 6, 6);
			updateTestBtn.Name = "updateTestBtn";
			updateTestBtn.Size = new System.Drawing.Size(198, 64);
			updateTestBtn.TabIndex = 2;
			updateTestBtn.Text = "Update test";
			updateTestBtn.UseVisualStyleBackColor = true;
			updateTestBtn.Click += updateTestBtn_Click;
			// 
			// deleteTestBtn
			// 
			deleteTestBtn.Enabled = false;
			deleteTestBtn.Location = new System.Drawing.Point(1099, 613);
			deleteTestBtn.Margin = new Padding(6, 6, 6, 6);
			deleteTestBtn.Name = "deleteTestBtn";
			deleteTestBtn.Size = new System.Drawing.Size(198, 64);
			deleteTestBtn.TabIndex = 3;
			deleteTestBtn.Text = "Delete test";
			deleteTestBtn.UseVisualStyleBackColor = true;
			deleteTestBtn.Click += deleteTestBtn_ClickAsync;
			// 
			// testListBox
			// 
			testListBox.FormattingEnabled = true;
			testListBox.ItemHeight = 41;
			testListBox.Location = new System.Drawing.Point(198, 131);
			testListBox.Margin = new Padding(6, 6, 6, 6);
			testListBox.Name = "testListBox";
			testListBox.Size = new System.Drawing.Size(828, 578);
			testListBox.TabIndex = 4;
			testListBox.SelectedIndexChanged += testListBox_SelectedIndexChanged;
			// 
			// viewTestResultsBtn
			// 
			viewTestResultsBtn.Location = new System.Drawing.Point(1395, 162);
			viewTestResultsBtn.Margin = new Padding(6);
			viewTestResultsBtn.Name = "viewTestResultsBtn";
			viewTestResultsBtn.Size = new System.Drawing.Size(261, 64);
			viewTestResultsBtn.TabIndex = 5;
			viewTestResultsBtn.Text = "View Test Results";
			viewTestResultsBtn.UseVisualStyleBackColor = true;
			viewTestResultsBtn.Click += viewTestResultsBtn_Click;
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1700, 922);
			Controls.Add(viewTestResultsBtn);
			Controls.Add(testListBox);
			Controls.Add(deleteTestBtn);
			Controls.Add(updateTestBtn);
			Controls.Add(addTestBtn);
			Controls.Add(takeTestBtn);
			Margin = new Padding(6, 6, 6, 6);
			Name = "MainMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainMenu";
			FormClosed += MainMenu_FormClosed;
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button takeTestBtn;
		private System.Windows.Forms.Button addTestBtn;
		private System.Windows.Forms.Button updateTestBtn;
		private System.Windows.Forms.Button deleteTestBtn;
		public System.Windows.Forms.ListBox testListBox;
		private Button viewTestResultsBtn;
	}
}