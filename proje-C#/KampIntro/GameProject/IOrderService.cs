using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IOrderService
    {

        void ApplyCampaign(Order order, Campaign campaign, Game game);
    }
}
