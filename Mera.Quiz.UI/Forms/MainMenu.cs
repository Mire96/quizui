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

namespace Mera.Quiz.UI.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            PopulateTestListBoxAsync();
            CheckUser();
        }

        //This method removes removes/shows buttons according to the role given
        private void CheckUser()
        {
            if(Session.GetInstance().currentUser.Role == RoleModel.USER)
            {
                this.addTestBtn.Hide();
                this.deleteTestBtn.Hide();
                this.updateTestBtn.Hide();
            }
        }

        private async Task PopulateTestListBoxAsync()
        {
            try
            {
                List<TestModel> testList = await APICalls.GetTests();
                this.testListBox.Items.AddRange(testList.ToArray());
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }
    }
}
