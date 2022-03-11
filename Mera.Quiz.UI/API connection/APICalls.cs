using Mera.Quiz.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mera.Quiz.UI.API_connection
{
    public class APICalls
    {
        public static async Task<List<TestModel>> GetTests()
        {
            string url = $"api/Test";

            using (HttpResponseMessage response = await APIHandler.client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var test = await response.Content.ReadAsAsync<List<TestModel>>();
                    return test;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
        #region User API
        public static async Task<UserModel> LoginUser(UserModel userModel)
        {
            string url = $"api/User/login";
            string userjson = JsonConvert.SerializeObject(userModel);

            var content = new StringContent(userjson, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await APIHandler.client.PostAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var userLogin = await response.Content.ReadAsAsync<UserModel>();
                    MessageBox.Show($"{userLogin.UserName} logged in successfuly as {userLogin.Role}", "Quiz register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return userLogin;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }


        public static async Task<UserModel> RegisterUser(UserModel userModel)
        {
            string url = $"api/User/create";
            string userjson = JsonConvert.SerializeObject(userModel);

            var content = new StringContent(userjson, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await APIHandler.client.PostAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var userLogin = await response.Content.ReadAsAsync<UserModel>();
                    MessageBox.Show($"{userLogin.UserName} registered successfuly as {userLogin.Role}", "Quiz register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return userLogin;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }

        #endregion

        internal static async Task DeleteTest(object selectedItem)
        {
            TestModel deleteTest = (TestModel)selectedItem;
            string url = $"api/Test/{deleteTest.ID}";

            using(HttpResponseMessage response = await APIHandler.client.DeleteAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"{deleteTest} deleted successfully", "Test deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }


        public static async Task<QuestionModel> ValidateQuestion(QuestionModel question)
        {
            string url = $"api/Question/validate";
            string questionJson = JsonConvert.SerializeObject(question);

            var content = new StringContent(questionJson, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await APIHandler.client.PostAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    QuestionModel validatedQuestion = await response.Content.ReadAsAsync<QuestionModel>();
                    MessageBox.Show("Question valid!");
                    return validatedQuestion;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal static async Task<int> CreateTestScore(TestModel testModel)
        {
            string url = $"api/Test/{testModel.ID}/Score";
            string testJson = JsonConvert.SerializeObject(testModel);

            var content = new StringContent(testJson, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await APIHandler.client.PostAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    int createdTestScore = await response.Content.ReadAsAsync<int>();
                    return createdTestScore;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal static async Task<TestModel> CreateTest(TestModel test)
        {
            string url = $"api/Test";
            string testjson = JsonConvert.SerializeObject(test);

            var content = new StringContent(testjson, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await APIHandler.client.PostAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    TestModel createdTest = await response.Content.ReadAsAsync<TestModel>();
                    MessageBox.Show($"{createdTest.TestName} was created!");
                    return createdTest;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
        //Refactor this code
        internal static async Task<TestModel> UpdateTest(TestModel test)
        {
            string url = $"api/Test/{test.ID}";
            string testjson = JsonConvert.SerializeObject(test);

            var content = new StringContent(testjson, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await APIHandler.client.PutAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    TestModel createdTest = await response.Content.ReadAsAsync<TestModel>();
                    MessageBox.Show($"{createdTest.TestName} was created!");
                    return createdTest;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
