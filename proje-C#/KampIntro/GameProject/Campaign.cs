
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Campaign
    {
        internal static string campaignName;

        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
