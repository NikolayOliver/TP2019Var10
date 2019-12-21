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
    public partial class Accountant : Form, IAccountantView
    {
        public CheckedListBox checkedListBox => checkedListBox1;
        public AccountantPresenter presenter; 

        public Accountant()
        {
            InitializeComponent();
        }

        private void CheckedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckerItems.HasCheckedOrders(checkedListBox1.CheckedItems.Count);
            presenter = new AccountantPresenter(this);
            MessageBox.Show(presenter.GetStatusOfOrders());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отгрузка прошла успешно");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CheckerItems.HasCheckedOrders(checkedListBox1.CheckedItems.Count);
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                MessageBox.Show("Для приходной нужно выбрать только один заказ");
                return;
            }
            presenter = new AccountantPresenter(this);
            presenter.ConfirmReceipt();
            MessageBox.Show("Приходная Оформлена");
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
