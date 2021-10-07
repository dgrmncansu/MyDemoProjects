using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
  public  interface ISalesService
    {
      

        (ICampaignService campaignService)

        {
            this.campaignService = campaignService;
        }

        ICampaignService campaignService { get; }

        public void ChooseCampaign(Gamer gamer)

        {
            campaignService.join(gamer);
        }

    }

}

   

