using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Model
{
    public class LoginModel
    {
        public string LoginText { get; set; }

        private IServiceContract<UserModel> userService => new UserService(LoginText);

        public void AddUser()
        {
            userService.AddElement();
        }
    }
}
