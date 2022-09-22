using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    //diyelimki yeni bir doğrulama sistemi kullanacağız.
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
