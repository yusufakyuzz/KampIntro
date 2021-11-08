using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30 olur değer tip olduğu için

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=?? 999 olur referasns tip olduğu için
            Console.WriteLine(sayilar1[0]);

            // REFERANS TİPLER DEĞİŞKENİN DEĞERİNİ DEĞİL BELLEKTE VERİLEN FİZİKSEL ADRES NUMARASINI TUTAR. 
            // HALİYLE SAYILAR1 İN ARTIK 10,20,30 DİYE DEĞERLERİNİN ADRESİNİ HİÇBİR DEĞİŞKEN TEMSİL ETMEDİĞİ İÇİN ARTIK SAYILAR2 NİN
            // DEĞERLERİNİ TUTUYOR.

            // ÖRNEK VERECEK OLURSAK
            /* 
             * Sayilar1 in fiziksel adresi 101 olsun diyelim
             * Sayilar2 içinde adres 102 olsun.
             * Biz bellekteki adres için ne diyoruz 
             * SAYİLAR1 in fiziksel adresini SAYİLAR2 nin adresi ile değiştir.
             * Yani ne oldu 100,200,300 ü artık SAYİLAR1 de tutuyor.
             * Haliyle SAYİLAR2 nin değerini değiştirdiğimizde onun fiziksel adresini SAYİLAR1 de tuttuğu için sonuç 999 olur.  
             */
        }
    }
}
