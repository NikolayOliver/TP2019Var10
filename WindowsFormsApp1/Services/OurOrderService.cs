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
    class OurOrderService : IServiceContract<OurOrderModel>
    {
        string nameProduct;
        int count;

        public OurOrderService(string name, int count)
        {
            this.count = count;
            nameProduct = name;
        }

        string writePath = @"E:\5 сем\TP\TP2019Var10\WindowsFormsApp1\OurOrders.json";

        OurOrdersRepository ourOrdersRepository => JsonSerializer.Deserialize<OurOrdersRepository>(File.ReadAllText(writePath));

        public void AddElement()
        {
            var id = CreateId();
            OurOrderModel orderModel = new OurOrderModel()
            {
                NameProduct = nameProduct,
                Id = id,
                Count = count
            };
            AddOrdersJson(orderModel);
        }

        public List<OurOrderModel> GetData()
        {
            return ourOrdersRepository.OurOrders;
        }

        private void AddOrdersJson(OurOrderModel order)
        {
            var orderRepository = ourOrdersRepository;

            if (orderRepository.OurOrders == null)
            {
                orderRepository.OurOrders = new List<OurOrderModel>();
                orderRepository.OurOrders.Add(order);
            }
            else
            {
                orderRepository.OurOrders.Add(order);
            }

            File.WriteAllText(writePath, JsonSerializer.Serialize<OurOrdersRepository>(orderRepository));
        }

        private string CreateId()
        {
            return "OurOrder " + (GetData().Count + 1);
        }

        public OurOrderModel FindElementById(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
