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
    public partial class CustomerManager : Form, ICustomerManagerView
    {
        public CheckedListBox checkedListBox => checkedListBox1;

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
            CheckerItems.HasCheckedOrders(checkedListBox1.CheckedItems.Count);
            var customerManagerPresenter = new CustomerManagerPresenter(this);
            customerManagerPresenter.AcceptOrders();
            MessageBox.Show("Заказ принят");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckerItems.HasCheckedOrders(checkedListBox1.CheckedItems.Count);
            var customerManagerPresenter = new CustomerManagerPresenter(this);
            MessageBox.Show(customerManagerPresenter.GetStatusOfOrders());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
