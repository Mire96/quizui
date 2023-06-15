using Mera.Quiz.UI.API_connection;
using Mera.Quiz.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mera.Quiz.UI
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private async void loginbtn_ClickAsync(object sender, EventArgs e)
		{
			UserModel user = new UserModel() { UserName = usernametxt.Text, Password = passwordtxt.Text };
			try
			{
				UserModel loggedInUser = await APICalls.LoginUser(user);
				Session.GetInstance().LoginUser(loggedInUser, this);
				this.Hide();
			}
			catch (Exception except)
			{
				MessageBox.Show(except.Message);

			}

		}

		private async void registerlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			UserModel user = new UserModel() { UserName = usernametxt.Text, Password = passwordtxt.Text };
			try
			{
				var result = MessageBox.Show("Do you want this user to be an admin?", "Role assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					user.Role = RoleModel.ADMIN;
				}
				else
				{
					user.Role = RoleModel.USER;
				}

				UserModel registeredUser = await APICalls.RegisterUser(user);
				Session.GetInstance().LoginUser(registeredUser, this);
				this.Hide();
			}
			catch (Exception except)
			{

				MessageBox.Show(except.Message, "Login error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
