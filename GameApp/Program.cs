using GameApp.Concrete;
using GameApp.Entities;
using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //YENİ BİR DOĞRULAMA SİSTEMİ ENTEGRE EDİYORUM.
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Yasin";
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer1);

            //Ürün oluşturma

            Game game1 = new Game();
            game1.Name = "LOL";
            game1.Price = 33;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            //Kampanya ekleme

            Compaign compaign1 = new Compaign();

            compaign1.Name = "yaz kampanyası";
            compaign1.DiscountRate = 23;

            CompaignManager compaignManager = new CompaignManager();

            compaignManager.Add(compaign1);

            compaignManager.CalculateDiscount(compaign1, game1);

            //Satış işlemleri(kampanyalı)

            SalesManager salesManager = new SalesManager(compaign1);

            salesManager.SellTo(gamer1, game1);



        }
    }
}
