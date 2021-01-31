using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Satis(Gamer game, Campaign campaign)
        {
            Console.WriteLine(game.GamerFirstName+ " oyuncusuna "+campaign.CampaignName +" ile satış yapıldı.");
        }
    }
}
