using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.ModelForMVP;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    public class AccountantPresenter : AbstractPresenter
    {
        public AccountantPresenter(IAccountantView view)
            : base(view)
        {
            service = new AccountantService();
        }

        public object[] ShowOrder() =>
            service.ShowOrders();

        public void ConfirmReceipt()
        {
            var serv = (service as AccountantService);
            foreach (var r in ViewCheckBox.checkedListBox.CheckedItems)
            {
                if (serv.CanCreateReceipt(GetId(r as string)))
                {
                    serv.CreateReceipt(GetId(r as string));
                    serv.SaveToTXTFile();
                    serv.AddElement();
                }
            }
        }
    }
}
