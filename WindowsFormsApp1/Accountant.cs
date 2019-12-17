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
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();
        }

        private void CheckedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплата не подтверждена");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отгрузка прошла успешно");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Receipt newForm = new Receipt();
            newForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Consumable newForm = new Consumable();
            newForm.Show();
           
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплата не прошла");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
