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
                Session.GetInstance().testList = testList;
                this.testListBox.DataSource = Session.GetInstance().testList;
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private async void deleteTestBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                await APICalls.DeleteTest(this.testListBox.SelectedItem);
                UpdateListBox();
                
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        //Can't update list box state
        private void UpdateListBox()
        {

            //testListBox.Items.Remove(testListBox.SelectedItem);
            //var tempList = testListBox.Items;
            Session.GetInstance().testList.Remove((TestModel)testListBox.SelectedItem);
            testListBox.DataSource = null;
            testListBox.DataSource = Session.GetInstance().testList;

            
        }

        private void testListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.testListBox.SelectedItem != null)
            {
                this.deleteTestBtn.Enabled = true;
                this.updateTestBtn.Enabled = true;
            }
            else
            {
                this.deleteTestBtn.Enabled = false;
                this.updateTestBtn.Enabled = false;
            }
        }

        private void addTestBtn_Click(object sender, EventArgs e)
        {
            CreateTestForm createTestForm = new CreateTestForm();
            createTestForm.Show();
        }
    }
}
