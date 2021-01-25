using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //başvuruda çeşitli bilgiler alırız
            //başvuran bilgilerini değerlendirme

            //BURADA BAŞVURU YAP IKREDIMANAGER hepsinin referansını tuttuğu için. BaşvuruYap metoduna
            //taşıt gönderirsen taşıtkredisi hepsalası çalışır. Konut gönderirsen konut kredisi HESAPLASI çalışır.

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
