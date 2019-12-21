using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class StatusType
    {
        public static readonly string New = "NEW";
        public static readonly string Processed = "PROCEEED"; //обработан
        public static readonly string Paid = "PAID"; //оплачено
        public static readonly string NonPaid = "Non PAID"; //не оплачено
        public static readonly string Ready = "Ready"; // готов на складе, осталось курьера подождать
        public static readonly string Assembled = "Assembled"; // Собран на складе
    }
}
