using System;
using System.Collections.Generic;
using System.Text;

namespace Mera.Quiz.UI.Models

{
    public class UserModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public RoleModel Role { get; set; }
    }
}
