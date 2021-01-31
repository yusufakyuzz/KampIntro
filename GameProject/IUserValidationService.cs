using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer); //interface tanımlıyoruz. Buradaki validate(doğrula) kısmı bool true ve false dönderecek
    }                               // işin nevine göre. Parametresi gamer yani doğrulanacak kişi. 
}                                   //burayı USER yapıp gamer customer vb. gibi diğerlerinide doğrulama yapabiliriz
