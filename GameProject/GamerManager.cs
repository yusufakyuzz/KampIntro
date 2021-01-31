using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {                                                   //  <<  //validation sınıfını iş sınıfları(Manager)
        IUserValidationService _userValidationService;          //içinde kullanmak istedğimiz için yukarda oluşturmuş
                                                                // olduğumuz sınfı tanımlıyoruz.
        public GamerManager(IUserValidationService userValidationService) //burayı oluşturmak için yukarda tanımlamış olduğumuz
        {                                                                 //_userValidationService ismine bir kez tıklıyoruz 
            _userValidationService = userValidationService;               // GENERATE CONSTRUCTAR  tıklıyoruz. Otomatik oluşuyor.
        }                                                                 // burada ki amaç bir manager içinde başka bir manager 
                                                                          // sınıfını kullanmak. Bu yüzden tanımlama yaptık.                                                                                   
        public void Add(Gamer gamer) // burası interface den implemente ettiğimiz için geliyor.
        {
            // şimdi doğrulama yaptıralım. IF ile
            if(_userValidationService.Validate(gamer)==true) // _userValidationService olarak tanımladığımız servisinden içinde ki
            {                                                // doğrula methoduna GAMER i gönderdik. sonuçları sistemden doğruladı
                Console.WriteLine("Oyuncu kayıt oldu");      // ise oyuncuyu kaydet dedik
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)// burası interface den implemente ettiğimiz için geliyor.
        {
            Console.WriteLine("Oyuncu silme başarılı");
        }

        public void Update(Gamer gamer)// burası interface den implemente ettiğimiz için geliyor. 
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
    }
}
