using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
        //kampanya servisimizi class ımıza implemente ettikten sonra hangi aksiyonları yapacağımızı yazdık.
        //burada ki Add Update  Delete ICampaignService den gelmektedir.
    }
}
