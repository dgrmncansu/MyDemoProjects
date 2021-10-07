using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class IOrderManager : IOrderService
    {



        public void Add(Sales sales)
        {
            Console.WriteLine("Siparişiniz Sepete eklendi");
        }
        ICampaignService campaignService;

        public ICampaignService ICampaignService { get; }

        public IOrderManager(ICampaignService campaignService)
        {
            ICampaignService = campaignService;
        }


        public void ApplyCampaign(Order order, Campaign campaign, Game game)
        {
            decimal CampaignService = (decimal)(game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100));
            if (game.UnitStock > 0) ;

            {
                Console.WriteLine(campaign.CampaignName + "applied");
                Console.WriteLine("Total price:" + campaignService);
            }


        }


           
        }

    }


