using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISalesService
    {
        void SellTo(Game game,Gamer gamer, Campaign campaign);
    }
}
