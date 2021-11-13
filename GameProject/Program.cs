using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                FirstName = "Yusuf",
                LastName = "Akyüz",
                Id = 1,
                TcNo = "1234567890",
                DogumYili = "1992"
            };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);

            UserValidationManager userValidationManager = new UserValidationManager();
            userValidationManager.UserValidationService(gamer1);

            Sales sales = new Sales { Id = 1, GameName = "Far Cry 5", Price = 350 };

            

            Campaign campaign1 = new Campaign { CampaignName="Bahar Kampanyası",Dicount=15};


            SalesManager salesManager = new SalesManager();
            salesManager.Sell(gamer1, sales, campaign1);
        }
    }
}
