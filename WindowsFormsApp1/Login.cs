using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class Login : Form, ILogin
    {
        public Login()
        {
            InitializeComponent();
        }

        string ILogin.Login
        {
            get
            {
                return loginText.Text;
            }
            set
            {
                loginText.Text = value;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            presenter.AddUser();
            User newForm = new User(presenter.GetCurrentUser());
            newForm.Show();
        }
    }
}
