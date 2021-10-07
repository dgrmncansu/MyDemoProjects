using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int GameId { get; internal set; }
        public DateTime OrderDate { get; internal set; }
        public int CampaignId { get; internal set; }
        public decimal Price { get; set; }

    }
}
