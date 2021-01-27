using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_Engin
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
