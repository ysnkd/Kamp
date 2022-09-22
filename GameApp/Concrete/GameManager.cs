using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    class GameManager : IGameService
    {
        List<Game> games = new List<Game>() { };
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.Name+ " oyun kaydedildi");
        }
    }
}
