using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KampanyaManager : IKampanyaService
    {
        public void Ekle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Eklendi : "+kampanya.Adi);
        }
    }
}
