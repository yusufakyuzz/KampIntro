using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SatisManager : ISatisManager
    {
        public void Sat(Kampanya kampanya, Satis satis, UserValidateManager userValidate)
        {
            Console.WriteLine("Satış yapıldı  \nKampanya Adı : "
                +kampanya.Adi+"\nSatış Id : "+satis.Id+" Satış Fiyatı : "+satis.Price);

        }
    }
}
