using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Model.ModelForMVP
{
    public class CreaterOrders
    {
        public string NameGood { get; set; }
        public int Count { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string LoginName { get; set; }

        private IServiceContract<OrderModel> orderService => new OrderService(NameGood, UserName, Count, Address, PhoneNumber, LoginName);

        public void ConfirmOrder()
        {
            orderService.AddElement();
        }

        public bool HasGoods(int count) => (orderService as OrderService).HasGoods(count);

        public bool CorrectNameProduct(string name) => (orderService as OrderService).CorrectNameProduct(name);
    }
}
