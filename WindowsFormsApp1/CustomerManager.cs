using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Questions newForm = new Questions();
            newForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ принят");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ отменен");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ не оплачен");
        }
    }
}
