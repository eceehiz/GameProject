using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı %" + campaign.DiscountRate + " indirim oranlı kampanya eklendi");
        }

        public double CalculateDiscount(Campaign campaign, Game game)
        {
            double newPrice = (game.GamePrice/ 100) * campaign.DiscountRate;
            newPrice = game.GamePrice - newPrice;
            game.GamePrice = newPrice;

            return game.GamePrice;
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya güncellendi");
        }
    }
}
