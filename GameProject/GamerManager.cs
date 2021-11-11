using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerManager
    {
        public void Add(GamerManager gamer)
        {
            Console.WriteLine("Oyuncu eklendi : "+ gamer);
        }

        public void Delete(GamerManager gamer)
        {
            Console.WriteLine("Oyuncu silindi : ");
        }

        public void Update(GamerManager gamer)
        {
            Console.WriteLine("Oyuncu güncellendi : ");
        }
    }
}
