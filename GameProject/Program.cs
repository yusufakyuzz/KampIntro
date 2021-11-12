using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer oyuncu1 = new Gamer() { Id = 1,Adi="Yunus",Soyadi="Akyüz",TcNo="123456789",DogumYili="1992" };

           

            UserValidateManager validateManager = new UserValidateManager();
            validateManager.UserValidate(oyuncu1);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Ekle(oyuncu1);

            Kampanya kampanya = new Kampanya() {Id=1,Adi="Bahar Kampanyasi",IndirimOrani="35" };
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Ekle(kampanya);

            Satis satis = new Satis();
            satis.Id = 1;
            satis.Price = 150;

            SatisManager satisManager = new SatisManager();
            satisManager.Sat(kampanya,satis , validateManager);

        }
    }
}
