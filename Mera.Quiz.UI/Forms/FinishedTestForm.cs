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
using System.CodeDom.Compiler;
using System.Diagnostics;
using PdfSharpCore;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.IO;

namespace Mera.Quiz.UI.Forms
{
	public partial class FinishedTestForm : Form
	{
		public TestModel test { get; set; }
		public event EventHandler TestCompleted;
		public FinishedTestForm(TestModel testModel)
		{
			test = testModel;
			InitializeComponent();
			label1.Text = $"Test score: {test.Score}\nIf you wish you can download a PDF file with your copy of the test";
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			GenerateTestResultPDF(test);
			MessageBox.Show("Test downloaded successfully");
			this.Close();
		}

		public void GenerateTestResultPDF(TestModel test)
		{
			// Create a new PDF document
			PdfDocument document = new PdfDocument();
			document.Info.Title = "Test Result - " + test.TestName;

			// Add a new page to the document
			PdfPage page = document.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);
			XFont testFont = new XFont("Arial", 20, XFontStyle.Regular);
			XFont questionFont = new XFont("Arial", 16, XFontStyle.Regular);
			XFont answerFont = new XFont("Arial", 12, XFontStyle.Regular);


			// Title
			gfx.DrawString("Test Result - " + test.TestName, testFont, XBrushes.Black,
				new XRect(0, 40, page.Width, page.Height), XStringFormats.TopCenter);

			// Student Name
			gfx.DrawString("User Name: " + test.UserName.UserName, testFont, XBrushes.Black,
				new XRect(50, 70, page.Width - 100, page.Height), XStringFormats.TopLeft);

			// Questions and Answers
			int yOffset = 100;

			for (int q = 0; q < test.QuestionList.Count; q++)
			{

				var question = test.QuestionList[q];
				int remainingSpace = (int)(page.Height.Point - yOffset);
				int questionLines = (int)gfx.MeasureString(question.QuestionText, questionFont).Height;
				int answerLines = (int)gfx.MeasureString(question.AnswerList.First().AnswerText, answerFont).Height * question.AnswerList.Count;

				if (questionLines + answerLines > remainingSpace)
				{
					// Add a new page if the question and answer cannot fit on the current page
					page = document.AddPage();
					gfx = XGraphics.FromPdfPage(page);
					yOffset = 40; // Reset the y-offset for the new page

					// Title (same for each page)
					gfx.DrawString("Test Result - " + test.TestName, testFont, XBrushes.Black,
						new XRect(0, 40, page.Width, page.Height), XStringFormats.TopCenter);

					// Student Name (same for each page)
					gfx.DrawString("Student Name: " + test.UserName.UserName, testFont, XBrushes.Black,
						new XRect(50, 70, page.Width - 100, page.Height), XStringFormats.TopLeft);
				}
				gfx.DrawString((q + 1) + ". " + question.QuestionText, questionFont, XBrushes.Black,
						new XRect(50, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
				yOffset += questionLines;


				for (int a = 0; a < question.AnswerList.Count; a++)
				{
					var answer = question.AnswerList[a];
					answerLines = (int)gfx.MeasureString(answer.AnswerText, answerFont).Height * question.AnswerList.Count;

					if (question.CorrectAnswer.AnswerText == answer.AnswerText)
					{
						var answerDisplayText = $"{a + 1}. {answer.AnswerText} - (Correct) ";
						gfx.DrawString(answerDisplayText, answerFont, XBrushes.Green,
							new XRect(60, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
						yOffset += answerLines; // Adding some extra space between questions
						if (answer.isChosen) continue;
					}
					else if(answer.isChosen)
					{
						var answerDisplayText = $"{a+1}. " + answer.AnswerText;
						gfx.DrawString(answerDisplayText, answerFont, XBrushes.Red,
							new XRect(60, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
						yOffset += answerLines; // Adding some extra space between questions
					}
					else
					{
						var answerDisplayText = $"{a+1}. " + answer.AnswerText;
						gfx.DrawString(answerDisplayText, answerFont, XBrushes.Black,
							new XRect(60, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
						yOffset += answerLines; // Adding some extra space between questions
					}


				}

			}

			// Save the document to a memory stream
			using (MemoryStream stream = new MemoryStream())
			{
				document.Save(stream, false);
				byte[] bytes = stream.ToArray();

				// Save the PDF to a file (you can also return the byte[] or send it to the response)
				File.WriteAllBytes("TestResult.pdf", bytes);
			}
		}

		private void FinishedTestForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			TestCompleted?.Invoke(this, EventArgs.Empty);
		}
	}
}
