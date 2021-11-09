using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Classımızdan yeni bir nesne oluşturup bizden istenen alanları dolduruyoruz.
             * 2 türlü veri girme şekli vardır. 
             * Örneğin;
             */

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //şimdilik 2 numara mobilyaya karşılık gelsin
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };

            ProductManager productManager = new ProductManager();  // Manager sınıfımızdan nesne oluşturuyoruz.
            productManager.Add(product1);                           // Manager sınıfımızda ki aksiyonlara nesne gönderiyoruz.
            Console.WriteLine(product1.ProductName);                // nesnemizin ürün isini ekrana basıyoruz.



          
        }
    }
}
