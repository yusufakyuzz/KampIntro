using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
       static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            // Burada dikkat etmemiz gereken yer IKrediManager diğer kredi çeşitlerinin bellketeki adreslerini
            // tuttuğunu bilmeliyiz. IKrediManager interface olduğu için NEWLENEMEZ. Haliyle tutmak istedğimiz
            // kredi türünün IKrediManager interface ine tutturabiliriz.

            // Başvuru işlemlerini operasyonları bildiğimiz üzere MANAGER sınıflarında yapıyoruz.
            // burada başvuru bilgilerinin hangi krediye uyumlu olup olmadığının veya hangilerini almak istiyor.
            // şartları ne onların aksiyonları için kullanıyoruz.

            List<ILoggerService> loggers = new List<ILoggerService> {databaseLoggerService,fileLoggerService,smsLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(esnafKrediManager,loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { };
            // Liste yöntemini kullanıyoruz. Sebebi ise birden fazla kredi hesaplamasını yapabilir diye. Bu verileride
            // IKrediManager üzerinden gönderiyoruz ki miras aldığı için bellekteki referans adreslerini tutsun diye
            
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
                
        }
    }
}
