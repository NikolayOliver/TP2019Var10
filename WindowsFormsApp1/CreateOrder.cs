using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Presenter;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class CreateOrder : Form, ICreaterOrder
    {
        private UserModel user;
        public string NameOrder
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string Count
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        public string UserName
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }
        public string Address
        {
            get
            {
                return textBox4.Text;
            }
            set
            {
                textBox4.Text = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return textBox5.Text;
            }
            set
            {
                textBox5.Text = value;
            }
        }

        public CreateOrder(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WareHouse newForm = new WareHouse();
            newForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var presenter = new CreaterOrderPresenter(this) { currentUser = user };
            presenter.CreateOrder();
            MessageBox.Show("Заказ подтвержден");
        }
    }
}
