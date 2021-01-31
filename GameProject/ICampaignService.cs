using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        /* burada ki amacımız ise olayları manager sınfında daha rahat kullanımı sağlamak. Örneğin kampanyanın yanı sıra
         Kampanyayı ekleyen oyuncunun ismini de yazdıracak olsaydık. 
         
          void Add(Campaign campaign, Gamer gamer); 

        yazacaktık. İş yükümüzü hafifletmek için
         */
        void Add(Campaign campaign); 
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
