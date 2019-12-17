using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Model.ModelForMVP;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    public class CreaterOrderPresenter : AbstractPresenter
    {
        ICreaterOrder orderView => view as ICreaterOrder;
        public UserModel currentUser;
        public CreaterOrderPresenter(ICreaterOrder createrView)
        {
            view = createrView;
        }

        public void CreateOrder()
        {
            CreaterOrders order = new CreaterOrders() { LoginName = currentUser.Name};
            order.NameGood = orderView.NameOrder;
            order.PhoneNumber = orderView.PhoneNumber;
            order.UserName = orderView.UserName;
            order.Count = Int32.Parse(orderView.Count);
            order.Address = orderView.Address;
            order.ConfirmOrder();
        }
    }
}
