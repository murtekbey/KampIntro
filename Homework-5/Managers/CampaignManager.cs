using Homework_5.Interfaces;
using Homework_5.Props;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Managers
{
    class CampaignManager
    {
        public double MakeCampaign(Game game, ICampaignService campaign)
        {
            return campaign.Discount(game.Price);
        }
    }
}
