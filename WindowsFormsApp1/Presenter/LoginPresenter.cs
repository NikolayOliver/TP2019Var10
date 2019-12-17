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
        public LoginPresenter(ILogin loginView)
        {
            view = loginView;
        }
        
        public UserModel GetCurrentUser() => new UserService((view as ILogin).Login).GetCurrentUser();

        public void AddUser()
        {
            LoginModel login = new LoginModel();
            login.LoginText = (view as ILogin).Login;
            login.AddUser();
        }
    }
}
