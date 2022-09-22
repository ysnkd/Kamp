using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    interface ICompaignService
    {
        void Add(Compaign compaign);
        void Update(Compaign compaign);
        void Delete(Compaign compaign);
        void CalculateDiscount(Compaign compaign, Game game);

    }
}
