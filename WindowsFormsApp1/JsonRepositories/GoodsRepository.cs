using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.JsonRepositories
{
    public class GoodsRepository
    {
        public List<Product> Products { get; set; }
        public List<OtherGood> OtherGoods { get; set; }
    }
}
