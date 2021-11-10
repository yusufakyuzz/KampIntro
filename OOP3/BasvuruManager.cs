using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    { 
        // Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //

            krediManager.Hesapla();
            foreach (ILoggerService loglayıcı in loggerServices)
            {
                loglayıcı.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // bana bir liste ver bu liste IKrediManager olsun
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
            //Liste yöntemi ile almış olduğumuz veriyi (IKrediManager) classındaki tüm veriyi FOR EACH ile tek tek dolaşıp
            //daha önceden overlad edilmiş olan Hesapla methodu ile hangi krediye aitse orayı hesaplayıp geri gönüş yapıyoruz.
        }
    }
}
