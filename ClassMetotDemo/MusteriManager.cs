using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" : müşterisi eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " : müşteri bilgileri getirildi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " : müşterisi silindi.");
        }
    }
}
