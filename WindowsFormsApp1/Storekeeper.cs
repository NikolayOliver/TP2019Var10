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
    public partial class Storekeeper : Form, IStoreKeeperView
    {
        StoreKeeperPresenter presenter;
        public Storekeeper()
        {
            InitializeComponent();
        }

        public CheckedListBox checkedListBox => checkedListBox1;

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
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выбрано 0 заказов");
                return;
            }
            presenter = new StoreKeeperPresenter(this);
            presenter.Assemblebatch();
            MessageBox.Show("Партия собрана упешно");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
