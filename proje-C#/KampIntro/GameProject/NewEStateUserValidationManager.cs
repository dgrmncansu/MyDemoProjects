using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{ 
    
    //Fake MernisServiceAdapter
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
