using Mera.Quiz.UI.Forms;
using Mera.Quiz.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mera.Quiz.UI
{
    public class Session
    {
        private static Session instance { get; set; }
        public UserModel currentUser { get; set; }

        public List<TestModel> testList { get; set; }

        private Session()
        {

        }

        public static Session GetInstance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        internal void LoginUser(UserModel user)
        {
            currentUser = user;
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

        }
    }
}
