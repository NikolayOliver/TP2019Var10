using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;

namespace WindowsFormsApp1.Services
{
    public class GetterGoods
    {
        string writePath = @"E:\5 сем\TP\TP2019Var10\WindowsFormsApp1\Products.json";
        GoodsRepository GoodRepository => JsonSerializer.Deserialize<GoodsRepository>(File.ReadAllText(writePath));

        public string GetStringProduct(ProductType type)
        {
            string returnedString = string.Empty;
            switch(type)
            {
                case ProductType.Apple:
                    foreach (var p in GoodRepository.Products)
                    {
                        if (p.Name == "Яблоко")
                           returnedString = p.Name + " x" + p.Count + " Стоимость:" + p.Cost;
                    }
                    break;
                case ProductType.Orange:
                    foreach (var p in GoodRepository.Products)
                    {
                        if (p.Name == "Апельсин")
                            returnedString = p.Name + " x" + p.Count + " Стоимость:" + p.Cost;
                    }
                    break;
                case ProductType.Papper:
                    foreach (var p in GoodRepository.OtherGoods)
                    {
                        if (p.Name == "Бумага")
                            returnedString = p.Name + " x" + p.Count + " Стоимость:" + p.Cost;
                    }
                    break;
            }
            return returnedString;
        }

        public void DeleteCountProducts(string nameGood, int count)
        {
            var newGoodRepository = GoodRepository;
            foreach (var oth in newGoodRepository.OtherGoods)
            {
                if (oth.Name == nameGood)
                {
                    oth.Count -= count;
                    break;
                }
            }
            foreach (var oth in newGoodRepository.Products)
            {
                if (oth.Name == nameGood)
                {
                    oth.Count -= count;
                    break;
                }
            }
            File.WriteAllText(writePath, JsonSerializer.Serialize<GoodsRepository>(newGoodRepository));
        }

        public List<string> GetListNamePrroducts()
        {
            var commonList = new List<string>();
            foreach (var oth in GoodRepository.OtherGoods)
            {
                commonList.Add(oth.Name);
            }
            foreach (var pr in GoodRepository.Products)
            {
                commonList.Add(pr.Name);
            }
            return commonList;
        }

        public int GetCountOfCurrentProduct(string productName)
        {
            foreach (var oth in GoodRepository.OtherGoods)
            {
                if (oth.Name == productName)
                {
                    return oth.Count;
                }
            }

            foreach (var oth in GoodRepository.Products)
            {
                if (oth.Name == productName)
                {
                    return oth.Count;
                }
            }

            return 0;
        }

        public void ReturnProducts(string nameGood, int count)
        {
            var newGoodRepository = GoodRepository;
            foreach (var oth in newGoodRepository.OtherGoods)
            {
                if (oth.Name == nameGood)
                {
                    oth.Count += count;
                    break;
                }
            }
            foreach (var oth in newGoodRepository.Products)
            {
                if (oth.Name == nameGood)
                {
                    oth.Count += count;
                    break;
                }
            }
            File.WriteAllText(writePath, JsonSerializer.Serialize<GoodsRepository>(newGoodRepository));
        }

        public int GetCost(string nameGood)
        {
            foreach (var oth in GoodRepository.Products)
            {
                if (oth.Name == nameGood)
                {
                    return oth.Cost;
                }
            }

            foreach (var pr in GoodRepository.Products)
            {
                if (pr.Name == nameGood)
                {
                    return pr.Cost;
                }
            }

            return 0;
        }
    }
}
