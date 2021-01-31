using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer) //burası interface den gelen validate metoduna göre gamer i doğrulama ekranıdır.
        {                                  // şartlar doğru ise interface e TRUE değilse FALSE  dönderecektir.
            if (gamer.GamerBirthDay == 1985 &&      // 1985 doğumlu ise
                gamer.GamerFirstName == "ENGİN" &&  // adı ENGİN  ise
                gamer.GamerLastName == "DEMİROĞ" && //soyadaı DEMİROĞ ise
                gamer.GamerIdentityNumber == 12345) // tc si 123456 ise
            {
                return true;                        // validate i TRUE yap
            }       
            else                                    //değilse 
            {
                return false;                       // FALSE yap
            }

        }
    }
}
