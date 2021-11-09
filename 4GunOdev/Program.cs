using System;

namespace _4GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(342, "Yusuf");
            ogrenciler.Add(1, "Birgül");
            ogrenciler.Add(5, "Yunus");
            ogrenciler.Add(6, "Emrah");

            Console.WriteLine(ogrenciler.Lenght);
           
            
        }
    }
}
