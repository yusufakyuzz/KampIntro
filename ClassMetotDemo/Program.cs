using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Yusuf";
            musteri1.Soyad = "Akyüz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Birgül";
            musteri2.Soyad = "Akyüz";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Yavuz";
            musteri3.Soyad = "Yücel";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("----------FOREACH BAŞLADI------------");
            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine(musteri.Id+" IDsine sahip "+ musteri.Ad+" "+musteri.Soyad+" isimli müşteri bulundu.");
                
            }
            Console.WriteLine("----------FOREACH SONU------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri3);

            //Console.WriteLine("Hello World!");
        }
    }
}
