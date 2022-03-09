using Mera.Quiz.UI.API_connection;
using Mera.Quiz.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            UserModel user = new UserModel() { UserName = usernametxt.Text, Password = usernametxt.Text };
            UserModel loggedInUser = await APICalls.LoginUser(user);
        }

        private void registerlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
