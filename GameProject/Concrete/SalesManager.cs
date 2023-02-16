using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        ICampaignService _campaignService;

        public SalesManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void SellTo(Game game, Gamer gamer, Campaign campaign)
        {
            game.GamePrice = _campaignService.CalculateDiscount(campaign , game);
            Console.WriteLine(gamer.FirstName + " adlı kullanıcı " + game.GameName + " adlı oyunu " + game.GamePrice + "TL'den satın aldı");
        }
    }
}
