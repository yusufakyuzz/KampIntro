using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool UserValidationService(Gamer gamer)
        {
            if (gamer.FirstName == "Yusuf" && gamer.LastName == "Akyüz"&&gamer.TcNo=="1234567890"&&gamer.DogumYili=="1992")
            {
                Console.WriteLine("User verified ");
                return true;
                
            }
            else
            {
                Console.WriteLine("User could not be verified");
                return false;
            }
        }
    }
}
