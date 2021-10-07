using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface ICampaignService
    {

        void Add(CampaignManager campaign);

        void Delete(CampaignManager campaign);

        void Update(CampaignManager campaign);
        void join(Gamer gamer);
    }
}
