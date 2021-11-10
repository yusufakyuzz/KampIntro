using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {   //Burada IhtiyacKrediManager classı IKrediManager dan miras alıyor neyi miras alıyor. BiseyYap() - Hesapla()
        public void BiseyYap()
        {
            Console.WriteLine("İhtiyaç Kredisi bişey yaptı");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
