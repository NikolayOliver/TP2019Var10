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
    public partial class StateOrder : Form
    {
        public StateOrder()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UserQuestion newForm = new UserQuestion();
            newForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар оформляется");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ отменен");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплата прошла успешно");
        }
    }
}
