using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
//1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz.
        //Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz.
        //(E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)
//2.Oyun satışı yapılabilecek satış ortamını simule ediniz.
        //(Yapılan satışlar oyuncu ile ilişkilendirilmelidir.Oyuncunun parametre olarak metotta olmasını kastediyorum.)
//3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
//4.Satışlarda kampanya entegrasyonunu simule ediniz.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------OYUNCU İŞLEMLERİ---------------------");
            GamerManager gamerManager = new GamerManager(new UserValidationManager ());
            gamerManager.Add(new Gamer {Id=1 , BirthYear= 1998, FirstName= "ECE", LastName= "HIZ", IdentityNumber=12345 });


            Console.WriteLine("----------------OYUN İŞLEMLERİ---------------------");
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game {Id=1, GameName="Mario", GamePrice=20 });


            Console.WriteLine("----------------KAMPANYA İŞLEMLERİ---------------------");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {Id=1, CampaignName= "For Mario" , DiscountRate= 20});


            Console.WriteLine("----------------SATIŞ İŞLEMLERİ---------------------");
            SalesManager salesManager = new SalesManager(new CampaignManager());
            salesManager.SellTo(new Game { Id = 1, GameName = "Mario", GamePrice = 20 }, 
                                new Gamer { Id = 1, BirthYear = 1998, FirstName = "ECE", LastName = "HIZ", IdentityNumber = 12345 },
                                new Campaign { Id = 1, CampaignName = "For Mario", DiscountRate = 20 });
        }
    }
}
