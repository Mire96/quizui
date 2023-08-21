using Mera.Quiz.UI.API_connection;
using Mera.Quiz.UI.Models;
using Mera.Quiz.UI.Forms;
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
	public partial class ViewTestResultsForm : Form
	{
		public UserModel currentUser { get; set; }
		public ViewTestResultsForm(Models.UserModel currentUser)
		{
			InitializeComponent();
			this.currentUser = currentUser;
			PopulateTestResultsListBox();
		}

		private async Task PopulateTestResultsListBox()
		{
			try
			{
				List<TestScoreModel> testResultsList = await APICalls.GetTestResults(currentUser.ID);
				this.testResultListBox.DataSource = testResultsList;
			}
			catch (Exception except)
			{
				MessageBox.Show(except.Message, "Test error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void downloadPdfBtn_Click(object sender, EventArgs e)
		{
			if(testResultListBox.SelectedItem != null)
			{
				TestScoreModel.GenerateTestResultPDF((TestScoreModel)testResultListBox.SelectedItem);
				MessageBox.Show("Test downloaded successfully");
			}
			else
			{
				MessageBox.Show("You must select a test result to download it's pdf");
			}
			
		}

		private async void ViewTestResultsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Session.GetInstance().mainMenu.Show();
			await Session.GetInstance().mainMenu.PopulateTestListBoxAsync();
		}
	}
}
