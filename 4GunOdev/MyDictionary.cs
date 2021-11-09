using System;
using System.Collections.Generic;
using System.Text;

namespace _4GunOdev
{
    class MyDictionary<K,V>
    {
        K[] diziAnahtar;
        V[] diziDeger;

        public MyDictionary()
        {
            diziAnahtar = new K[0];
            diziDeger = new V[0];
        }

        public void Add(K anahtar,V deger)
        {
            K[] tempAnahtar = diziAnahtar;   // anahtar kaybı olmasın diye geçiçi anahtarları tutacak dizi
            V[] tempDeger = diziDeger;      //  değer   kaybı olmasın diye geçiçi değerleri tutacak dizi

            diziAnahtar = new K[tempAnahtar.Length + 1]; // asıl olan dizimi ve yeniden hafızaya +1 ekleyerek yer açıyoruz.
            diziDeger = new V[tempDeger.Length + 1];     // asıl olan dizimi ve yeniden hafızaya +1 ekleyerek yer açıyoruz.

            for (int i = 0; i < tempAnahtar.Length; i++) // döngü ile geçiçi devrettiğimiz değerlerimizi tekrar alıyoruz.
            {
                diziAnahtar[i] = tempAnahtar[i];
                diziDeger[i] = tempDeger[i];
            }

            diziAnahtar[diziAnahtar.Length - 1] = anahtar; // yeni anahtarları yazıyoruz.
            diziDeger[diziDeger.Length - 1] = deger;       // yeni değerleri yazıyoruz.



        }

        public int Lenght                           // dizimizde toplam kaç boyutlu sayıyoruz.
        {
            get { return diziAnahtar.Length; }
        }

       // BİRAZ YARDIMIM DOKUNDUYSA YILDIZ VERMEYİ UNUTMA :) KOLAY GELSİN SEN BAŞARIRSIN.
    }
}
