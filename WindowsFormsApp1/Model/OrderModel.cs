using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class OrderModel : IModel
    {
        public string NameGood { get; set; }
        public string Id { get; set; }
        public int Count { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public string Status { get; set; }
    }
}
