using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Model
{
    class OurOrderModel : IModel
    {
        public string Id { get; set; }
        public int Count { get; set; }
        public string NameProduct { get; set; }

        private IServiceContract<OurOrderModel> orderService => new OurOrderService(NameProduct, Count);

        public void ButtonOk()
        {
            orderService.AddElement();
        }
    }
}
