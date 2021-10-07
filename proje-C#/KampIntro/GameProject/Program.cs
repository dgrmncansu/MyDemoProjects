using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        private static Gamer gamer;

        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager  ());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1991,
                FirstName = "Cansu",
                LastName = "Değirmen",
                IdentityNumber = 12345
  
            });
            gamerManager.Add(gamer);
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign=new Campaign { CampaignId=1,CampaignName= "Eğlenceli %25 İndirimi" , DiscountRate=0.25M };
            campaignManager.Add(campaign);

            GamerManager gameManager = new GamerManager();
            Game game = new Game { GameId = 1, GameName = "Minecraft", gamePrice = 145 };
            gameManager.Add(game);


            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game);
            salesManager.CampaignSales(game, gamer, campaign);




               
        }
    }
}