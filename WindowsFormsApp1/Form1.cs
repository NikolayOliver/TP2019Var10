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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PManager newForm = new PManager();
            newForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CustomerManager newForm = new CustomerManager();
            newForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Delivery newForm = new Delivery();
            newForm.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();
            newForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Accountant newForm = new Accountant();
            newForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Storekeeper newForm = new Storekeeper();
            newForm.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
