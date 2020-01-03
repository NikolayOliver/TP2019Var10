using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    class OurOrdersPresenter : AbstractPresenter
    {
        IOurFinishedView ourOrderView => View as IOurFinishedView;
        ICreateOurOrdersView createOurOrdersView => View as ICreateOurOrdersView;
        OurOrderModel order;

        public OurOrdersPresenter(IOurFinishedView ourOrderView)
            :base(ourOrderView)
        {
        }

        public OurOrdersPresenter(ICreateOurOrdersView createOurOrdersView)
            :base(createOurOrdersView)
        {
        }

        GetterGoods getterGoods = new GetterGoods();

        public string GetStringProduct() => getterGoods.GetFinishedProducts();

        public void ButtonOk()
        {
            order = new OurOrderModel();
            order.Count = Int32.Parse(createOurOrdersView.Count);
            order.NameProduct = createOurOrdersView.NameProduct;
            order.ButtonOk();
        }
    }
}
