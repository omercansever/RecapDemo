using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOmercan
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Added this Campaign" + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted this Campaign" + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updated this Campaign" + campaign.CampaignName);
        }
    }
}
