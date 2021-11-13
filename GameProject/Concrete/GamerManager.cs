using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer added : " + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated : "+gamer.FirstName);
        }
    }
}
