using System;
using Types;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Ranges(name: "audi", storeName: "AudiShop");
            var t2 = new Ranges(name: "mercedes", storeName: "MBshop");
            var t3 = new Ranges(name: "bmw", storeName: "bmwShop");
            var t4 = new Ranges(name: "mazda", storeName: "MazdaShop");
            var t5 = new Ranges(name: "mitsubishi", storeName: "MitsubishiMBshop");


            var product = new Product();
            product.AddProduct(t1);
            product.AddProduct(t2);
            product.AddProduct(t3);
            product.AddProduct(t4);
            product.AddProduct(t5);

            Console.WriteLine("\tNot sort list:");
            product.Print();

            product.Soring();

            Console.WriteLine("\tSort list:");
            product.Print();

            product.FindShop(Console.ReadLine());


        }
    }
}