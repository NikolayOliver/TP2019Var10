using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class ReceiptModel : IModel
    {
        public string Client { get; set; }

        public int Sum { get; set; }

        public string NameProduct { get; set; }

        public int CountProduct { get; set; }

        public string Id { get; set; }
    }
}
