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
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class StateOrder : Form, IWorkWithOrder
    {
        UserModel User { get; set; }
        WorkWithOrderPresenter presenter => new WorkWithOrderPresenter(this);
        public CheckedListBox checkedListBox
        {
            get
            {
                return checkedListBox1;
            }
        }


        public StateOrder(UserModel user)
        {
            User = user;
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
            CheckerItems.HasCheckedOrders(checkedListBox1.CheckedItems.Count);
            MessageBox.Show(presenter.GetStatusOfOrders());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckerItems.HasCheckedOrders(checkedListBox1.CheckedItems.Count);
            presenter.DeleteOrders();
            MessageBox.Show("Заказы отменены");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CheckerItems.HasCheckedOrders(checkedListBox1.CheckedItems.Count);
            presenter.CheckPayment();
            MessageBox.Show("Выполняется оплата обработанных заказов");
        }

        private object[] GetLoginNameData()
        {
            object[] listOfOrdersId = null;
            var list = new OrderService().GetDataOfCurrentName(User.Name);
            if (list.Count == 3)
            {
                listOfOrdersId = new object[] {
                list[0].Id + " " + list[0].NameGood,
                list[1].Id + " " + list[1].NameGood,
                list[2].Id + " " + list[2].NameGood
                };
            }

            if(list.Count == 2)
            {
                listOfOrdersId = new object[] {
                list[0].Id + " " + list[0].NameGood,
                list[1].Id + " " + list[1].NameGood
                };
            }

            if(list.Count == 1)
            {
                listOfOrdersId = new object[] {
                list[0].Id + " " + list[0].NameGood
                };
            }

            return listOfOrdersId;
        }
    }
}
