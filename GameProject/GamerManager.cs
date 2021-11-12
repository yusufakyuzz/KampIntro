using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGameService
    {
       
        public void Ekle(Gamer gamer)
        {
            Console.WriteLine("Oyuncu ekleme başarılı : "+gamer.Adi+" "+gamer.Soyadi);
        }

        public void Guncelle(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncelleme başarılı : " + gamer.Adi + " " + gamer.Soyadi);
        }

        public void Sil(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silme başarılı : " + gamer.Adi + " " + gamer.Soyadi);
        }
    }
}
