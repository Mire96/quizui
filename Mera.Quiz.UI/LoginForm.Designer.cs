
using System.Windows.Forms;

namespace Mera.Quiz.UI
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			usernametxt = new TextBox();
			usernamelbl = new Label();
			passwordlbl = new Label();
			passwordtxt = new TextBox();
			registerlbl = new LinkLabel();
			loginbtn = new Button();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// usernametxt
			// 
			usernametxt.Location = new System.Drawing.Point(463, 609);
			usernametxt.Margin = new Padding(6, 6, 6, 6);
			usernametxt.Name = "usernametxt";
			usernametxt.Size = new System.Drawing.Size(308, 47);
			usernametxt.TabIndex = 0;
			usernametxt.Text = "Milos";
			// 
			// usernamelbl
			// 
			usernamelbl.AutoSize = true;
			usernamelbl.Location = new System.Drawing.Point(238, 615);
			usernamelbl.Margin = new Padding(6, 0, 6, 0);
			usernamelbl.Name = "usernamelbl";
			usernamelbl.Size = new System.Drawing.Size(157, 41);
			usernamelbl.TabIndex = 1;
			usernamelbl.Text = "UserName";
			// 
			// passwordlbl
			// 
			passwordlbl.AutoSize = true;
			passwordlbl.Location = new System.Drawing.Point(255, 709);
			passwordlbl.Margin = new Padding(6, 0, 6, 0);
			passwordlbl.Name = "passwordlbl";
			passwordlbl.Size = new System.Drawing.Size(143, 41);
			passwordlbl.TabIndex = 2;
			passwordlbl.Text = "Password";
			// 
			// passwordtxt
			// 
			passwordtxt.Location = new System.Drawing.Point(463, 703);
			passwordtxt.Margin = new Padding(6, 6, 6, 6);
			passwordtxt.Name = "passwordtxt";
			passwordtxt.PasswordChar = '*';
			passwordtxt.Size = new System.Drawing.Size(308, 47);
			passwordtxt.TabIndex = 3;
			passwordtxt.Text = "Milos";
			// 
			// registerlbl
			// 
			registerlbl.AutoSize = true;
			registerlbl.Location = new System.Drawing.Point(544, 1095);
			registerlbl.Margin = new Padding(6, 0, 6, 0);
			registerlbl.Name = "registerlbl";
			registerlbl.Size = new System.Drawing.Size(125, 41);
			registerlbl.TabIndex = 4;
			registerlbl.TabStop = true;
			registerlbl.Text = "Register";
			registerlbl.LinkClicked += registerlbl_LinkClicked;
			// 
			// loginbtn
			// 
			loginbtn.Location = new System.Drawing.Point(521, 912);
			loginbtn.Margin = new Padding(6, 6, 6, 6);
			loginbtn.Name = "loginbtn";
			loginbtn.Size = new System.Drawing.Size(187, 90);
			loginbtn.TabIndex = 5;
			loginbtn.Text = "Login";
			loginbtn.UseVisualStyleBackColor = true;
			loginbtn.Click += loginbtn_ClickAsync;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.GRqoSib7eDiGGTL_Quiz_Logo_PNG_HD;
			pictureBox1.Location = new System.Drawing.Point(6, 6);
			pictureBox1.Margin = new Padding(6, 6, 6, 6);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(1239, 543);
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(565, 1031);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(86, 41);
			label1.TabIndex = 7;
			label1.Text = "- or -";
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1241, 1275);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(loginbtn);
			Controls.Add(registerlbl);
			Controls.Add(passwordtxt);
			Controls.Add(passwordlbl);
			Controls.Add(usernamelbl);
			Controls.Add(usernametxt);
			Margin = new Padding(6, 6, 6, 6);
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox usernametxt;
		private System.Windows.Forms.Label usernamelbl;
		private System.Windows.Forms.Label passwordlbl;
		private System.Windows.Forms.TextBox passwordtxt;
		private System.Windows.Forms.LinkLabel registerlbl;
		private System.Windows.Forms.Button loginbtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}

