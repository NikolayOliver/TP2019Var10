using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Services
{
    public class AccountantService : AbstractService
    {
        ReceiptRepository ReceiptRepository => JsonSerializer.Deserialize<ReceiptRepository>(File.ReadAllText(writePath));

        string writePath = @"E:\5 сем\TP\TP2019Var10\WindowsFormsApp1\Receipt.json";
        string writePathTxt = @"E:\5 сем\TP\TP2019Var10\WindowsFormsApp1\Receipt.txt";
        public string client;
        public string nameProduct;
        public int countProduct;
        GetterGoods getterGoods = new GetterGoods();

        public override object[] ShowOrders()
        {
            var listOrders = orderService.GetData();
            object[] listOfOrdersData = null;
            if (listOrders.Count == 1)
            {
                return listOfOrdersData;
            }
            listOfOrdersData = new object[listOrders.Count - 1];
            for (int i = 0; i < listOrders.Count - 1; i++)
            {
                if (listOrders[i + 1].Status == StatusType.NonPaid || listOrders[i + 1].Status == StatusType.Paid)
                    listOfOrdersData[i] = listOrders[i + 1].Id + " " + listOrders[i + 1].LoginName;
            }
            return listOfOrdersData;
        }

        public void CreateReceipt(string idOrder)
        {
            var order = orderService.FindElementById(idOrder);
            client = order.LoginName;
            nameProduct = order.NameGood;
            countProduct = order.Count;
            ChangeStatus(order, StatusType.Ready, idOrder);
        }

        public bool CanCreateReceipt(string idOrder)
        {
            var order = orderService.FindElementById(idOrder);
            return order.Status == StatusType.Paid;
        }

        public void AddElement()
        {
            var id = CreateId();
            var sum = GetSum();
            ReceiptModel orderModel = new ReceiptModel()
            {
                Client = client,
                Sum = sum,
                CountProduct = countProduct,
                Id = id,
                NameProduct = nameProduct
            };

            AddReceiptJson(orderModel);
        }

        public int GetSum() =>
            getterGoods.GetCost(nameProduct) * countProduct;

        private void AddReceiptJson(ReceiptModel order)
        {
            var receiptRepository = ReceiptRepository;

            if (receiptRepository.ReceiptLists == null)
            {
                receiptRepository.ReceiptLists = new List<ReceiptModel>();
                receiptRepository.ReceiptLists.Add(order);
            }
            else
            {
                ReceiptRepository.ReceiptLists.Add(order);
            }

            File.WriteAllText(writePath, JsonSerializer.Serialize<ReceiptRepository>(ReceiptRepository));
        }

        public void SaveToTXTFile()
        {
            using (StreamWriter sw = new StreamWriter(writePathTxt, true, Encoding.UTF8))
            {
                sw.Write(CreateReceiptString());
            }
        }

        private string CreateReceiptString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Приход: ");
            stringBuilder.Append(GetData().Count);
            stringBuilder.Append(", Клиент: ");
            stringBuilder.Append(client);
            stringBuilder.Append(", Продукт: ");
            stringBuilder.Append(nameProduct);
            stringBuilder.Append(", Количество: ");
            stringBuilder.Append(countProduct);
            stringBuilder.Append(", Общая стоимость: ");
            stringBuilder.Append(GetSum());
            stringBuilder.Append(", Дата и время: ");
            stringBuilder.Append(DateTime.Now);
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }

        public List<ReceiptModel> GetData()
        {
            return ReceiptRepository.ReceiptLists;
        }

        private string CreateId()
        {
            return "Receipt " + (GetData().Count + 1);
        }
    }
}
