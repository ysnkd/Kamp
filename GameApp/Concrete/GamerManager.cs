using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    //MicroService
    class GamerManager : IGamerService
    {
        //hiç bir class'ı çıplak bırakmayacağız. (interface)
        //Eğer bir manager classında bir manager classı kullanacaksak onu sakın newleme!
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        //CONSTRUCTOR ; BU ŞU DEMEK GAMERMANAGER'IN userValidationServis adında bir BAĞIMLILIĞI VAR! GAMERMANAGER SINIFINDA 
        // BİR DOĞRULAMA KULLANACAĞIM DEMEK
        //KULLANDIĞIMIZ CONSTRUCTOR DEĞER ALAN CONSTRUCTOR. MAİNDE GAMERMANAGER'İ NEWLEDİĞİMDE YANINDA PARANTEZ
        //OLARAK BİR DOĞRULAMA SİSTEMİNİ YAZMALIYIZ. ZORUNDAYIZ
        public void Add(Gamer gamer)
        {
            if(userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName+ " kayıt oldu");

            }
            else
            {
                Console.WriteLine("kayıt başarısız");
            }
            //GAMER'İ DOĞRULADIYSAN KAYIT OLDU MESAJI VER!
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
