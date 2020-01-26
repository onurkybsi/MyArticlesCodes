using System;
using System.Collections.Generic;

namespace yieldKeywordEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product{ ProductName = "Computer", Price = 6000};
            Product product2 = new Product{ ProductName = "Mobile Phone", Price = 3000};
            Product product3 = new Product{ ProductName = "TV", Price = 4000};

            Product.AddProduct(product1);
            Product.AddProduct(product2);
            Product.AddProduct(product3);

            foreach(var item in Product.GetProducts)
            {
                Console.WriteLine("Product Name: {0}, Price: {1}",item.ProductName,item.Price);
            }

            Console.ReadKey();
        }
    }

    class Product
    {
        private static List<Product> productRepo = new List<Product>();
        public string ProductName { get; set; }
        public int Price { get; set; }
        public static void AddProduct(Product product)
        {
            productRepo.Add(product);
        }
        public static IEnumerable<Product> GetProducts
        {
            get
            {
                for(int i = 0; i < productRepo.Count; i++)
                {
                    yield return productRepo[i];
                }
            }
        }
    }
}
