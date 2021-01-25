using System;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(1, "Yusuf");
            ogrenci.Add(1, "Akyüz");
            ogrenci.Add(1, "Engin Demiroğ");
            ogrenci.Add(1, "Yıldız ver");
            ogrenci.Add(1, "Ankara");
            ogrenci.Add(1, "Yozgat");
            ogrenci.Add(1, "Yusuf");
            Console.WriteLine(""+ogrenci.Length());

        }
    }
}
