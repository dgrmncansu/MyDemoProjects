using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{

    // MicroService
    class GamerManager : IGamerService
    {
        private NewEStateUserValidationManager newEStateUserValidationManager;

        public GamerManager(NewEStateUserValidationManager newEStateUserValidationManager)
        {
            this.newEStateUserValidationManager = newEStateUserValidationManager;
        }

        public GamerManager()
        {
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt oldu");
        }

        internal void Add(object gamer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}

