using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService
    {
        void Add(Gamer gamer);  //burayı oluşturmamızın sebebi hiç bir sınıfı çıplak bırakmamak. Oluşturacağımız sınıflarda ki
        void Update(Gamer gamer);// manager sınıflarının servisini oluşturarak onları daha dinamik hale getirmek. Servisler yardımı
        void Delete(Gamer gamer);// ile sınıfları dinamikleştirmek.
    }
}
