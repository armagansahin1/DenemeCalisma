using System;

namespace GenericClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(){Id=1,CategoryName = "Shoes",ProductName = "Nike Shoe",UnitPrice = 700};
            Product product2 = new Product() { Id = 2, CategoryName = "Tshirt", ProductName = "Zara Tshirt", UnitPrice = 120 };

            MyList<Product> producList = new MyList<Product>();
            
            producList.Add(product1);
            producList.Add(product2);

            producList.List(product1);
        }
    }
}
