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
    public class OrderService : IServiceContract<OrderModel>
    {
        string nameOrder;
        string userName;
        int count;
        string address;
        string phoneNumber;
        string loginName;

        string writePath = @"E:\5 сем\TP\TP2019Var10\WindowsFormsApp1\Orders.json";

        OrdersRepository ordersRepository => JsonSerializer.Deserialize<OrdersRepository>(File.ReadAllText(writePath));

        GetterGoods goods = new GetterGoods();

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
                Status = StatusType.New.ToString(),
                Id = id,
                UserName = userName
            };
            DeleteSomeProducts();
            AddOrdersJson(orderModel);
        }

        public void DeleteSomeProducts()
        {
            GetterGoods goods = new GetterGoods();
            goods.DeleteCountProducts(nameOrder, count);
        }

        public OrderService()
        {
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

        public OrderModel FindElementById(string id)
        {
            OrderModel orderModel = null;
            foreach (var ordMod in ordersRepository.OrdersList)
            {
                if (ordMod.Id == id)
                    orderModel = ordMod;
            }
            return orderModel;
        }

        public List<OrderModel> GetData()
        {
            return ordersRepository.OrdersList;
        }

        private string CreateId()
        {
            return "Order " + (GetData().Count + 1);
        }

        private void AddOrdersJson(OrderModel order)
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

        public void SetOrdersJson(OrdersRepository orderRepository)
        {
            File.WriteAllText(writePath, JsonSerializer.Serialize<OrdersRepository>(orderRepository));
        }

        public List<OrderModel> GetDataOfCurrentName(string name)
        {
            var list = GetData();
            var listOfCurrentName = new List<OrderModel>();
            foreach(var l in list)
            {
                if (l.LoginName == name)
                {
                    listOfCurrentName.Add(l);
                }
            }
            return listOfCurrentName;
        }

        public bool HasGoods(int productsCount) =>
            goods.GetCountOfCurrentProduct(nameOrder) >= productsCount;
        

        public bool CorrectNameProduct(string productName)
        {
            foreach (var n in goods.GetListNamePrroducts())
            {
                if (n == productName)
                    return true;
            }
            return false;
        }
    }
}
