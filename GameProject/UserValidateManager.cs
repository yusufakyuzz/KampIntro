using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidateManager : IValidationService
    {
        public bool UserValidate(Gamer gamer)
        {
            if (gamer.Adi =="Yusuf" && gamer.Soyadi == "Akyüz" && gamer.Id == 1 && gamer.TcNo == "1234567890" && gamer.DogumYili == "1992")
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
