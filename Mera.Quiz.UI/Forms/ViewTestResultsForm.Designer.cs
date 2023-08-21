namespace Mera.Quiz.UI.Forms
{
	partial class ViewTestResultsForm
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
			testResultListBox = new System.Windows.Forms.ListBox();
			button1 = new System.Windows.Forms.Button();
			downloadPdfBtn = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// testResultListBox
			// 
			testResultListBox.FormattingEnabled = true;
			testResultListBox.ItemHeight = 41;
			testResultListBox.Location = new System.Drawing.Point(56, 70);
			testResultListBox.Margin = new System.Windows.Forms.Padding(6);
			testResultListBox.Name = "testResultListBox";
			testResultListBox.Size = new System.Drawing.Size(1615, 578);
			testResultListBox.TabIndex = 5;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(64, 887);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(1607, 58);
			button1.TabIndex = 6;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// downloadPdfBtn
			// 
			downloadPdfBtn.Location = new System.Drawing.Point(64, 768);
			downloadPdfBtn.Name = "downloadPdfBtn";
			downloadPdfBtn.Size = new System.Drawing.Size(1607, 58);
			downloadPdfBtn.TabIndex = 7;
			downloadPdfBtn.Text = "Download Result PDF";
			downloadPdfBtn.UseVisualStyleBackColor = true;
			downloadPdfBtn.Click += downloadPdfBtn_Click;
			// 
			// ViewTestResultsForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1730, 1044);
			Controls.Add(downloadPdfBtn);
			Controls.Add(button1);
			Controls.Add(testResultListBox);
			Name = "ViewTestResultsForm";
			Text = "ViewTestResultsForm";
			FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTestResultsForm_FormClosed);
			ResumeLayout(false);
		}

		#endregion

		public System.Windows.Forms.ListBox testResultListBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button downloadPdfBtn;
	}
}