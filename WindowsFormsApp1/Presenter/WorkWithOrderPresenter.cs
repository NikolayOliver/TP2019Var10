using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    public class WorkWithOrderPresenter : AbstractPresenter
    { 
        public WorkWithOrderPresenter(IWorkWithOrder view) 
            : base(view)
        {
            service = new WorkerWithOrderService(); 
        }

        public void DeleteOrders()
        {
            foreach (var w in ViewCheckBox.checkedListBox.CheckedItems)
            {
                (service as WorkerWithOrderService).DeleteOrder(GetId(w as string));
            }
        }

        public void CheckPayment()
        {
            foreach (var w in ViewCheckBox.checkedListBox.CheckedItems)
            {
                (service as WorkerWithOrderService).SetPaymentStatus(GetId(w as string));
            }
        }
    }
}
