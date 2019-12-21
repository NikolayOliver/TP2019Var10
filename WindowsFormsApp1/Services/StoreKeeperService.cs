using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    public class StoreKeeperService : AbstractService
    {
        public override object[] ShowOrders()
        {
            var listOrders = orderService.GetData();
            object[] listOfOrdersData = null;
            if (listOrders.Count == 1)
            {
                return listOfOrdersData;
            }
            listOfOrdersData = new object[listOrders.Count - 1];
            for (int i = 0; i < listOrders.Count - 1; i++)
            {
                if (listOrders[i + 1].Status == StatusType.Ready)
                    listOfOrdersData[i] = listOrders[i + 1].Id + " " + listOrders[i + 1].LoginName;
            }
            return listOfOrdersData;
        }

        public void AssembleBatch(string idOrder)
        {
            var order = orderService.FindElementById(idOrder);
            ChangeStatus(order, StatusType.Assembled, idOrder);
        }
    }
}
