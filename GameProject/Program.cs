using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer oyuncu1 = new Gamer();
            oyuncu1.GamerId = 1;
            oyuncu1.FirstName = "Yusuf";
            oyuncu1.LastName = "Akyüz";
            oyuncu1.NationalId = "12345678900";
            oyuncu1.BirthDate = "1992";

            IGamerManager gamerManager = new GamerManager();
            gamerManager.Add(oyuncu1);
        }

    }
}
