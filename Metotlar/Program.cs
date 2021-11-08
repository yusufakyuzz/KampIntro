using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 }; //ürün dizisi oluşturduk.

            //type safe -- tip güvenli
            foreach (Urun urun in urunler)
            {               
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------------Methodlar------------------");

            //instance - örnek
            //encapsulation - enkapsüleyşın - kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //YAPILMASI TAVSİYE EDİLMEYEN KULLANIM ŞEKLİ
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);  //anasayfadan sepete ekle butonu
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);    //indirimli ürünler sayfasından sepete ekleme butonu
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);   // mobilden sepete ekle butonu 
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice 