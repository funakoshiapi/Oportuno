using System;
using System.Collections.Generic;
using Oportuno.Models;
using static Oportuno.Models.Store;

namespace Oportuno.Data
{
    public class MockOportunoRepo : IOportunoRepo
    {
        public Store GetStoreById(int id)
        {
            return new Store {Id = 1, Name="Love",  Email = "Kabungula@store.com", Phone ="244-344-3456", StoreService = ServiceType.Barbearia , Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"};
        }
      
        public IEnumerable<Store> GetAppStores()
        {
            var appStores = new List <Store>
            {
                new Store {Id = 0, Name="Ronaldo", Email = "ronaldo@store.com", Phone ="351-344-3456", StoreService = ServiceType.Barbearia, Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new Store {Id = 1, Name="Love",  Email = "Kabungula@store.com", Phone ="244-344-3456", StoreService = ServiceType.Yoga , Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new Store {Id = 2, Name="Flavio",  Email = "Flavio@store.com", Phone ="244-344-3456", StoreService = ServiceType.Dentista , Image = "https://www.zerozero.pt/img/treinadores/271/554271_med__20190306164158_flavio_amado.jpg"}
            };
            return appStores;
        }

        public AppUser GetAppUserById (int id)
        {
         return new AppUser {Id = 0, FirstName="Ronaldo", Email = "ronaldo@fifa.com", Phone ="351-344-3456", Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"};
        }

        public IEnumerable<AppUser> GetAppUsers()
        {
            var appUsers = new List <AppUser>
            {
                new AppUser {Id = 0, FirstName="Ronaldo", LastName= "Cristiano", Email = "ronaldo@fifa.com", Phone ="351-344-3456", Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new AppUser {Id = 1, FirstName="Love", LastName= "Kabungula", Email = "Kabungula@fifa.com", Phone ="244-344-3456", Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new AppUser {Id = 2, FirstName="Flavio", LastName= "Amado", Email = "Flavio@fifa.com", Phone ="244-344-3456", Image = "https://www.zerozero.pt/img/treinadores/271/554271_med__20190306164158_flavio_amado.jpg"}
  

            };
        
            return appUsers;
        }
    }
}