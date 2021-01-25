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

            // IKrediManager konutKrediManager = new EsnafKredisiManager();
            // parantez içinde new EsnafKredisiManager() ile üstteki kullanım ikiside aynı şeyi ifade eder

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new SmsLoggerService() } ;

            BasvuruManager basvuruManager = new BasvuruManager();
            

            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
            // Kaç tane kredi türü hesaplanacağı bilmediğimiz için bir liste oluşturuyoruz. IKrediManager türünde
            // sonra bunu kullanıyoruz.

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
