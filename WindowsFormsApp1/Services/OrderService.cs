using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Services
{
    // realize function, add check statuc,
    class OrderService : IServiceContract<OrderModel>
    {
        string nameOrder;
        string userName;
        int count;
        string address;
        string phoneNumber;
        string loginName;

        string writePath = @"E:\5 сем\TP\TP2019Var10\WindowsFormsApp1\Orders.json";

        OrdersRepository ordersRepository => JsonSerializer.Deserialize<OrdersRepository>(File.ReadAllText(writePath));

        public void AddElement()
        {
            var id = CreateId();
            OrderModel orderModel = new OrderModel()
            {
                NameGood = nameOrder,
                Address = address,
                Count = count,
                LoginName = loginName,
                PhoneNumber = phoneNumber,
                Status = StatusType.New,
                Id = id,
                UserName = userName
            };
            SetOrdersJson(orderModel);
        }

        public OrderService(string nameOrder, string userName, int count, string address, string phoneNumber, string LoginName)
        {
            this.nameOrder = nameOrder;
            this.userName = userName;
            this.count = count;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.loginName = LoginName;
        }

        public OrderModel FindElementById(string Id)
        {
            return new OrderModel();
        }

        public List<OrderModel> GetData()
        {
            return ordersRepository.OrdersList;
        }

        private string CreateId()
        {
            return "Order " + (GetData().Count + 1);
        }

        private void SetOrdersJson(OrderModel order)
        {
            var orderRepository = ordersRepository;

            if (orderRepository.OrdersList == null)
            {
                orderRepository.OrdersList = new List<OrderModel>();
                orderRepository.OrdersList.Add(order);
            }
            else
            {
                orderRepository.OrdersList.Add(order);
            }

            File.WriteAllText(writePath, JsonSerializer.Serialize<OrdersRepository>(orderRepository));
        }
    }
}
