using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager: IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt olunmadı");
            }
        }
        public void Update (Gamer gamer){
            Console.WriteLine("Kayıt güncellendi");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

    }

}
