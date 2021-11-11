using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerManager
    {
        void Add(GamerManager gamer);
        void Delete(GamerManager gamer);
        void Update(GamerManager gamer);
    }
}
