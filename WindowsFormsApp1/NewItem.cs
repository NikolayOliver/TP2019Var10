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
    public partial class NewItem : Form, ICreateOurOrdersView
    {
        public NewItem()
        {
            InitializeComponent();
        }

        public string NameProduct
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

        private void Button1_Click(object sender, EventArgs e)
        {
            var presenter = new OurOrdersPresenter(this);
            presenter.ButtonOk();
            MessageBox.Show("Товар заказан");
        }
    }
}
