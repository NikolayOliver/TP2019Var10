using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Services
{
    public class AbstractService  
    {
        public OrderService orderService = new OrderService();

        public void ChangeStatus(OrderModel order, string newStatus, string idOrder)
        {
            order.Status = newStatus;
            var ordersList = orderService.GetData();
            ordersList = ordersList.Where(or => or.Id != idOrder).ToList();
            ordersList.Add(order);
            orderService.SetOrdersJson(new OrdersRepository() { OrdersList = ordersList });
        }

        public virtual object[] ShowOrders()
        {
            return null;
        }

        public string GetStatusOfOrder(string idOrder)
        {
            var order = orderService.FindElementById(idOrder);
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("ID: ");
            stringBuilder.Append(order.Id);
            stringBuilder.Append("; Имя продукта: ");
            stringBuilder.Append(order.NameGood);
            stringBuilder.Append("; Статус: ");
            stringBuilder.Append(order.Status);

            return stringBuilder.ToString();
        }
    }
}
