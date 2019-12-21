using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class CheckerItems
    {
        //?
        public static void HasCheckedOrders(int count)
        {
            if (count == 0)
            {
                MessageBox.Show("Не выбран ни один заказ");
                return;
            }
        }
    }
}
