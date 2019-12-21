using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;

namespace WindowsFormsApp1.Services
{
    public class WorkerWithOrderService : AbstractService
    {
        public void DeleteOrder(string idOrder)
        {
            ReturnCountProduct(idOrder);
            var ordersList = orderService.GetData();
            ordersList = ordersList.Where(or => or.Id != idOrder).ToList();
            orderService.SetOrdersJson(new OrdersRepository() { OrdersList = ordersList });
        }

        public void ReturnCountProduct(string idOrder)
        {
            var count = orderService.FindElementById(idOrder).Count;
            var nameProduct = orderService.FindElementById(idOrder).NameGood;
            new GetterGoods().ReturnProducts(nameProduct, count);
        }

        private bool CheckPayment()
        {
            var random = new Random();
            var randomValue = random.Next(100);

            return randomValue > new Random().Next(50);
        }

        public void SetPaymentStatus(string idOrder)
        {
            var order =  orderService.FindElementById(idOrder);
            if (order.Status == StatusType.Processed)
            {
                if (CheckPayment())
                {
                    ChangeStatus(order, StatusType.Paid, idOrder);
                }
                else
                {
                    ChangeStatus(order, StatusType.NonPaid, idOrder);
                }
            }
        }
    }
}
