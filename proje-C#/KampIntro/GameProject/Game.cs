using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Game
    {
        internal int gamePrice;

        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Gence  { get; internal set; }
        public decimal Price { get; internal set; }
        public int UnitStock { get; internal set; }
        public int GamePrice { get; internal set; }
    }
}
