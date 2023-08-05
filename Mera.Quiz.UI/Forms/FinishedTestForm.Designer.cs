namespace Mera.Quiz.UI.Forms
{
	partial class FinishedTestForm
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
			label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(95, 153);
			label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(0, 41);
			label1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(177, 385);
			button1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(333, 96);
			button1.TabIndex = 1;
			button1.Text = "Download PDF";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new System.Drawing.Point(697, 385);
			button2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(357, 96);
			button2.TabIndex = 2;
			button2.Text = "Return to main menu";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// FinishedTestForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1326, 615);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			Name = "FinishedTestForm";
			Text = "FinishedTestForm";
			FormClosed += FinishedTestForm_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}