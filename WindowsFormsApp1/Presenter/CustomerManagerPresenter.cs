using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    public class CustomerManagerPresenter : AbstractPresenter
    {
        public CustomerManagerPresenter(ICustomerManagerView  view)
            :base(view)
        {
            service = new CustomerManagerService();
        }

        public void AcceptOrders()
        {
            foreach (var ch in ViewCheckBox.checkedListBox.CheckedItems)
            {
                (service as CustomerManagerService).AsseptOrder(GetId(ch as string));
            }
        }

        public object[] GetDataOfOrders() =>
            service.ShowOrders();
    }
}
