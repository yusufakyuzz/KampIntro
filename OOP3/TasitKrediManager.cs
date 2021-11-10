using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {   //Burada TasitKrediManager classı IKrediManager dan miras alıyor neyi miras alıyor. BiseyYap() - Hesapla()
        public void BiseyYap()
        {
            Console.WriteLine("Taşıt Kredisi bişey yaptı");
        }

        public void Hesapla()
        {
            //
            //

            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
