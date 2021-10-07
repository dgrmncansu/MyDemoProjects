using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public static int DiscountRate { get; internal set; }
        public string CampanignName { get; private set; }

        public void Add(CampaignManager campaign)
        {
            Console.WriteLine( campaign .CampanignName  +  "  "  + "isimli kampanya eklendi");
        }

        public void Delete(CampaignManager campaign)
        {
            Console.WriteLine(campaign.CampanignName + "  " + "isimli kampanya silindi");
        }

        public void Update(CampaignManager campaign)
        {
            Console.WriteLine(campaign.CampanignName + "  " + "isimli kampanya güncellendi");
        }

        internal void Add(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
