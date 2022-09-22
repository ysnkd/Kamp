using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    interface ISalesService
    {
        void SellTo(Gamer gamer, Game game);
    }
}
