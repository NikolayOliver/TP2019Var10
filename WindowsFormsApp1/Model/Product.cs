using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Product : IModel
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int StartCount { get; set; }
        public int Cost { get; set; }
    }
}
