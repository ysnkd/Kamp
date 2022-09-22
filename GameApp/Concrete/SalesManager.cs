using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    class SalesManager : ISalesService
    {
        

        public SalesManager(Compaign compaign)
        {
            compaign = compaign;
        }

        public void SellTo(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı kullanıcı " + game.Name + " adlı oyunu " + game.Price + " fiyatında aldı ");
        }
    }
}
