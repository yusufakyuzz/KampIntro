using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.ProductName = "Klavye";
            urun1.Price = 400;

            Product urun2 = new Product();
            urun2.ProductName = "Mouse";
            urun2.Price = 35;

            Product urun3 = new Product();
            urun3.ProductName = "Monitör";
            urun3.Price = 350;

            Product urun4 = new Product();
            urun4.ProductName = "Laptop";
            urun4.Price = 3650;

            Product urun5 = new Product();
            urun5.ProductName = "TV";
            urun5.Price = 4500;


            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4, urun5 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ProductName + " : " + urunler[i].Price + "  FOR");
            }

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.ProductName + " : " + urun.Price + "    FOREACH");
            }

            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine(urunler[x].ProductName + " : " + urunler[x].Price + "  WHİLE");
                x++;
            }
        }

        class Product
        {
            public string ProductName { get; set; }
            public int Price { get; set; }
        }

    }
}
