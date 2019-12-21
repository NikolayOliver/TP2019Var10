using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;

namespace WindowsFormsApp1.Services
{
    public class CustomerManagerService : AbstractService
    {
        public void AsseptOrder(string idOrder)
        {
            var order = orderService.FindElementById(idOrder);
            if (order.Status == StatusType.New)
            {
                ChangeStatus(order, StatusType.Processed, idOrder);
            }
        }

        public override object[] ShowOrders()
        {
            var listOrders = orderService.GetData();
            object[] listOfOrdersData = null;
            if (listOrders.Count == 1)
            {
                return listOfOrdersData;
            }
            listOfOrdersData = new object[listOrders.Count - 1];
            for (int i = 0; i < listOrders.Count -1 ; i++)
            {
                listOfOrdersData[i] = listOrders[i+1].Id + " " + listOrders[i+1].LoginName;
            }
            return listOfOrdersData;
        }
    }
}
