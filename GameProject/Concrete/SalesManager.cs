using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {
        public void Sell(Gamer gamer,Sales sales,Campaign campaign)
        {
            Console.WriteLine("GamerId : "+gamer.Id +"\nGamer Name : "+gamer.FirstName+" "+gamer.LastName +
                "\nCampaign Name : "+campaign.CampaignName+
                "\nDiscount Price : "+campaign.Dicount+
                "\n"+sales.GameName+ " Purchased");
        }

       
    }
}
