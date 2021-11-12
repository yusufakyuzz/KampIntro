using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        void Ekle(Gamer gamer);
        void Sil(Gamer gamer);
        void Guncelle(Gamer gamer);
    }
}
