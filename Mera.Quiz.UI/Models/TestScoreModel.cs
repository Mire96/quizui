using Microsoft.VisualBasic.ApplicationServices;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mera.Quiz.UI.Models
{
	public class TestScoreModel
	{
		public int ID { get; set; }

        public TestModel Test { get; set; }
        public UserModel User { get; set; }

		public int Score { get; set; }

		public DateTime DateTaken { get; set; }

		public List<UserAnswers> UserAnswers { get; set; }

		public override string ToString()
		{
			return $"{Test.TestName} - Date taken: {DateTaken} - Score: {Score}";
		}

		public static void GenerateTestResultPDF(TestScoreModel testScore)
		{
			// Create a new PDF document
			PdfDocument document = new PdfDocument();
			document.Info.Title = "Test Result - " + testScore.Test.TestName;

			// Add a new page to the document
			PdfPage page = document.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);
			XFont testFont = new XFont("Arial", 20, XFontStyle.Regular);
			XFont questionFont = new XFont("Arial", 16, XFontStyle.Regular);
			XFont answerFont = new XFont("Arial", 12, XFontStyle.Regular);
			XFont correctAnswerFont = new XFont("Arial", 12, XFontStyle.Bold);

			var testName = testScore.Test.TestName;
			var userName = testScore.User.UserName;
			// Title
			gfx.DrawString("Test Result - " + testName, testFont, XBrushes.Black,
				new XRect(0, 40, page.Width, page.Height), XStringFormats.TopCenter);

			// Student Name
			gfx.DrawString("User Name: " + userName, testFont, XBrushes.Black,
				new XRect(50, 70, page.Width - 100, page.Height), XStringFormats.TopLeft);

			// Questions and Answers
			int yOffset = 100;

			for (int q = 0; q < testScore.UserAnswers.Count; q++)
			{
				var userAnswer = testScore.UserAnswers[q];
				var question = userAnswer.Question;
				var chosenAnswer = userAnswer.ChosenAnswer;

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
					gfx.DrawString("Test Result - " + testName, testFont, XBrushes.Black,
						new XRect(0, 40, page.Width, page.Height), XStringFormats.TopCenter);

					// Student Name (same for each page)
					gfx.DrawString("Student Name: " + userName, testFont, XBrushes.Black,
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
						if (answer.AnswerText == chosenAnswer.AnswerText)
						{
							gfx.DrawString(answerDisplayText, correctAnswerFont, XBrushes.Green,
							new XRect(60, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
						}
						else
						{
							gfx.DrawString(answerDisplayText, answerFont, XBrushes.Green,
							new XRect(60, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
						}

						yOffset += answerLines; // Adding some extra space between questions

					}
					else if (answer.AnswerText == chosenAnswer.AnswerText)
					{
						var answerDisplayText = $"{a + 1}. " + answer.AnswerText;
						gfx.DrawString(answerDisplayText, correctAnswerFont, XBrushes.Red,
							new XRect(60, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
						yOffset += answerLines; // Adding some extra space between questions
					}
					else
					{
						var answerDisplayText = $"{a + 1}. " + answer.AnswerText;
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

	}
}
