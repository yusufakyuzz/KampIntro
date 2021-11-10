using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {   //Burada KonutKrediManager classı IKrediManager dan miras alıyor neyi miras alıyor. BiseyYap() - Hesapla()
        public void BiseyYap()
        {
            Console.WriteLine("Konut Kredisi bişey yaptı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
