using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    public abstract class AbstractPresenter
    {
        public IView View { get; set; }
        public IViewCheckBox ViewCheckBox { get; set; }
        public AbstractService service;
        public AbstractPresenter(IView view)
        {
            View = view;
        }

        public AbstractPresenter(IViewCheckBox viewCheckBox)
        {
            ViewCheckBox = viewCheckBox;
        }

        public static string GetId(string nameOfOrder)
        {
            var wordsInName = nameOfOrder.Split();
            return wordsInName[0] + " " + wordsInName[1];
        }

        public string GetStatusOfOrders()
        {
            var orderStringBuilder = new StringBuilder();
            foreach (var ch in ViewCheckBox.checkedListBox.CheckedItems)
            {
                orderStringBuilder.AppendLine(service.GetStatusOfOrder(GetId(ch as string)));
            }

            return orderStringBuilder.ToString();
        }
    }
}
