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
    public partial class Storekeeper : Form
    {
        public Storekeeper()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ оформлен");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ отгружен");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Партия собрана упешно");
        }
    }
}
