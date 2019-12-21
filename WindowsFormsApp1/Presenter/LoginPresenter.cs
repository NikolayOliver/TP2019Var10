using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    public class LoginPresenter : AbstractPresenter
    {
        ILogin loginView => View as ILogin;
        public LoginPresenter(ILogin loginView) 
            :base(loginView)
        {
        }
        
        public UserModel GetCurrentUser() => new UserService(loginView.Login).GetCurrentUser();

        public void AddUser()
        {
            LoginModel login = new LoginModel();
            login.LoginText = loginView.Login;
            login.AddUser();
        }
    }
}
