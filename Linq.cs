using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace Tutor
{
    class ProductInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static IEnumerable<ProductInfo> GetProductByQuery(IEnumerable<ProductInfo> products, Func<ProductInfo,bool> predicate)
        {
            return products.Where(predicate);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    
    public class Linq
    {
        public static void WriteData(IEnumerable<object> values)
        {
            foreach (var value in values)
            {
                WriteLine(value);
            }
        }
        private static void Main1(string[] args)
        {
            var names = new[] { "chety", "clooney", "lol" };
            var result = CustomFilterFunction(names, name => name.Length > 3);
            WriteData(result);
            WriteLine("************************************");

            result = CustomMapFunction(names, name => $"{name} bambuçya");
            WriteData(result);
            WriteLine("************************************");

            #region Product Query
            var productList = new List<ProductInfo>
            {
                new ProductInfo{Id = 1, Name = "Book"},
                new ProductInfo{Id = 2, Name = "Laptop"},
                new ProductInfo{Id = 3, Name = "Cellphone"},
                new ProductInfo{Id = 4, Name = "Music Player"}
            };
            var result2 = ProductInfo.GetProductByQuery(productList, item => item.Id > 2);
            foreach (var product in result2)
            {
                WriteLine(product);
            }
            #endregion Product Query

            ReadLine();
        }

        private static IEnumerable<string> CustomFilterFunction(IEnumerable<string> values, Predicate<string> predicate)
        {
            return values.Where(value => predicate(value));
        }

        private static IEnumerable<string> CustomMapFunction(IEnumerable<string> values, Func<string,string> myFunc)
        {
            var valueList = values.ToList();
            var copyValues = new List<string>(valueList.Count);
            valueList.ForEach(item => copyValues.Add(myFunc(item)));
            return copyValues;
        }
    }
}
