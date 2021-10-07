using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGamerService
    {

        //IGamerService-Soyut olanı
        //IGamerManager-Somut olanı

        //gamer lar user olarakda eklenebilir
        
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);


    }
}
