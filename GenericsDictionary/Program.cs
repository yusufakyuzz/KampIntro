using System;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(1, "Yusuf");
            ogrenci.Add(2, "Akyüz");
            ogrenci.Add(3, "Engin Demiroğ");
            ogrenci.Add(4, "Yıldız ver");
            ogrenci.Add(55, "Ankara");
            ogrenci.Add(7, "Yozgat");
            ogrenci.Add(9, "Yusuf");
            Console.WriteLine(""+ogrenci.Length());

        }
    }
}
