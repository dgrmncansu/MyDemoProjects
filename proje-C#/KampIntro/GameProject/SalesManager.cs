using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        private object campaign;
        private object campanign;

        public double Price { get; set; }
        public string Type { get; set; }
        public int UnitStock { get; set; }
        public string CampaignName { get; private set; }

        public void Sales(Gamer gamer, Game game)


        {
            decimal discountedSales = game.gamePrice - (game.gamePrice + CampaignManager.DiscountRate);
            Console.WriteLine(game.GameName + "isimli oyun" + gamer.FirstName + " " + gamer.LastName + " isimlikullanıcıya"
                 + " kampanyası ile" + discountedSales + "TL" + " fiyat ile satıldı");
        }

        public void CampaignSales(Game game, Gamer gamer, CampaignManager campaign)
        {
            Console.WriteLine(game.GameName + "isimli oyun" + gamer.FirstName + " " + gamer.LastName + " isimli kullanıcıya"
              + game.GamePrice + "TL" + " fiyat ile satıldı");

        }

        internal void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }

  }
