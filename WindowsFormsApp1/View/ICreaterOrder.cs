using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View
{
    public interface ICreaterOrder : IView
    {
        string NameOrder { get; set; }
        string Count { get; set; }
        string UserName { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
