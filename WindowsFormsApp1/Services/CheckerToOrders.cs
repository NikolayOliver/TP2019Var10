using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    public class CheckerToOrders : AbstractService
    {    
        public bool CanDoNewOrder(string name)
        {
            int countOfOrders = 0;
            foreach(var o in orderService.GetData())
            {
                if (o.LoginName == name)
                {
                    countOfOrders++;
                }
            }

            if (countOfOrders > 3)
            {
                return false;
            }

            return true;
        }
    }
}
