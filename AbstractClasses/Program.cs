using System;
using System.Collections.Concurrent;
using System.Net.Http.Headers;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(){ProductName = "Cep Telefonu", UnitPrice = 7000};
            Console.WriteLine("-----------------ESKİ MÜŞTERİ----------------------");
            ProductManager productManager = new OldCustomer();  
            productManager.Get(product);                          // Burada eski müşteri olarak hesap yapacak

            Console.WriteLine("*********************************"); 
            
            Console.WriteLine("-----------------YENİ MÜŞTERİ----------------------");
            ProductManager productManager2 = new NewCustomer(); 
            productManager2.Get(product);                         // Burada yeni müşteri olarak %10 indirimli bir şekilde ürünü görecek

        }
        abstract class ProductManager     // abstarct classlar abstract keyword ü ile tanımlanır
        {
            public abstract void Get(Product product);    

        }

        class OldCustomer:ProductManager
        {
            public override void Get(Product product)         // Farklı kod çalıştıracak metod override ile yazılı ve class içinde implemente edilmesi gerekir
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.UnitPrice);
            }
        }

        class NewCustomer:ProductManager
        {
            public override void Get(Product product)
            {
                double newPrice = product.UnitPrice * 90 / 100;
                Console.WriteLine(product.ProductName);
                Console.WriteLine("Ürün Fiyatı : "+newPrice);
            }
        }

        class Product
        {
            public string ProductName { get; set; }
            public double UnitPrice { get; set; }
        }
        

    }
}
