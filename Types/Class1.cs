using System.Collections.Generic;

namespace Types
{
    public struct Ranges
    {
        public string Name { get; set; }
        public string StoreName { get; set; }
        public Ranges(string name, string storeName)
        {
            Name = name;
            StoreName = storeName;
        }

    }
    public struct Product
    {
        public Product()
        {
        }
        List<Ranges> productList = new List<Ranges>();
        public void AddProduct(Ranges product)
        {
            productList.Add(product);
        }
        public void Soring()
        {
            productList = productList.OrderBy(x => x.StoreName).ToList();
        }
        public void Print()
        {
            foreach (Ranges product in productList)
                Console.WriteLine($"Product: {product.Name}\n Shop: {product.StoreName}");
        }
        public void FindShop(string nameshop)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].StoreName.ToLower() == nameshop.ToLower())
                {
                    Console.WriteLine($"Shop <{productList[i].StoreName}> has <{productList[i].Name}>");
                    return;
                }
            }
            throw new UserExeption(nameshop);
        }
    }
    public class UserExeption : ApplicationException
    {
        public UserExeption(string x)
        {
            Console.WriteLine($"The store with the name <{x}> does not exist.");
        }
    }
}