using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager()); // burada gamermanager sınıfını tanımlıyoruz.
                                                                                       // sonra oyuncuyu doğrulayacağımız için 
            Gamer gamer1 = new Gamer();                                                // Kullanıcı Doğrulama Manager sınıfını 
            gamer1.GamerId = 1;                                                        // GameManager içinde tanımlıyoruz.
            gamer1.GamerFirstName = "ENGİN";                                           //sonra UserValidationManager sınıfında ki 
            gamer1.GamerLastName = "DEMİROĞ";                                          //değerleri burada oyuncu oluşturup içine 
            gamer1.GamerBirthDay = 1985;                                               //yazıyoruz. Bilgiler doğru ise
            gamer1.GamerIdentityNumber=12345;                                          //kayıt başarılı değilse başarısız yazacak
             
             

            ////////////////KAMPANYA EKLEME SİLME GÜNCELLEME////////////////////
            Campaign newCampaign = new Campaign();
            newCampaign.CampaignId = 1;
            newCampaign.CampaignName = "Sevgililer Günü Kampanyası";
            newCampaign.CampaignPrice = 65;
            newCampaign.CampaignStock = 18;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(newCampaign);

            campaignManager.Delete(newCampaign);

            campaignManager.Update(newCampaign);

            /////////////////////////////////////////////////////////////////////




            Sales satis = new Sales();
            satis.SalesId = 2;
            satis.SalesName = "Oyun";

           

            SalesManager salesManager = new SalesManager();
            salesManager.Satis(gamer1, newCampaign);




        }

        
        


    }
}
