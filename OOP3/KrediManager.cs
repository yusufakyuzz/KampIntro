using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    { // burada Class KrediManager yazan kısımdan class ı silip İNTERFACE yazıyoruz.
      // KrediManagerin bir interface olduğunu belli etmek için başına I koyuyoruz. IKrediManager
      // methodlardan public i siliyoruz.
      
      // Biz burada interface de neyi verirsek Miras alan sayfalarda onlarıda bulundurmak zorundadır.
        void Hesapla();
        void BiseyYap();
       
    }
}
