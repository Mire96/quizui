﻿using Mera.Quiz.UI.Models;
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
                    MessageBox.Show(userLogin.UserName);
                    return userLogin;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal static async Task DeleteTest(object selectedItem)
        {
            TestModel deleteTest = (TestModel)selectedItem;
            string url = $"api/Test/{deleteTest.ID}";

            using(HttpResponseMessage response = await APIHandler.client.DeleteAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"{deleteTest} deleted successfully");
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
                    MessageBox.Show(userLogin.UserName);
                    return userLogin;
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

    }
}
