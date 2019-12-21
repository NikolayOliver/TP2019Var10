using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    public class StoreKeeperPresenter : AbstractPresenter
    {
        public StoreKeeperPresenter(IStoreKeeperView view)
            :base(view)
        {
            service = new StoreKeeperService();
        }

        public object[] ShowOrders() =>
            service.ShowOrders();

        public void Assemblebatch()
        {
            var serv = (service as StoreKeeperService);
            foreach (var ser in ViewCheckBox.checkedListBox.CheckedItems)
            {
                serv.AssembleBatch(GetId(ser as string));
            }
        }
    }
}
