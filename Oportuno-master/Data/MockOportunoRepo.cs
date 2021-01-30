using System;
using System.Collections.Generic;
using Oportuno.Entities;
using static Oportuno.Entities.Store;

namespace Oportuno.Data
{
    public class MockOportunoRepo : IOportunoRepo
    {
        public Store GetStoreById(int id)
        {
            return new Store {Id = 1, Name="Love",  Email = "Kabungula@store.com", Phone ="244-344-3456", StoreService = ServiceType.Barbearia , Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"};
        }
      
        public IEnumerable<Store> GetAllStores()
        {
            var appStores = new List <Store>
            {
                new Store {Id = 1, Name="Ronaldo", Email = "ronaldo@store.com", Phone ="351-344-3456", StoreService = ServiceType.Barbearia, Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new Store {Id = 2, Name="Love",  Email = "Kabungula@store.com", Phone ="244-344-3456", StoreService = ServiceType.Yoga , Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new Store {Id = 3, Name="Flavio",  Email = "Flavio@store.com", Phone ="244-344-3456", StoreService = ServiceType.Dentista , Image = "https://www.zerozero.pt/img/treinadores/271/554271_med__20190306164158_flavio_amado.jpg"}
            };
            return appStores;
        }

        public User GetUserById(int userId)
        {

            var listUsers = new List<User>
            {
                new User {Id = 1, FirstName="Ronaldo", LastName= "Cristiano", Email = "ronaldo@fifa.com", Phone ="351-344-3456", Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new User {Id = 2, FirstName="Love", LastName= "Kabungula", Email = "Kabungula@fifa.com", Phone ="244-344-3456", Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new User {Id = 3, FirstName="Flavio", LastName= "Amado", Email = "Flavio@fifa.com", Phone ="244-344-3456", Image = "https://www.zerozero.pt/img/treinadores/271/554271_med__20190306164158_flavio_amado.jpg"}


            };

            foreach (User obj in listUsers) 
            { 
                if (obj.Id == userId)
                {
                    return obj;
                }
            }



            return null;
        }
         

        public IEnumerable<User> GetAllUsers()
        {
            var User = new List <User>
            {
                new User {Id = 1, FirstName="Ronaldo", LastName= "Cristiano", Email = "ronaldo@fifa.com", Phone ="351-344-3456", Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new User {Id = 2, FirstName="Love", LastName= "Kabungula", Email = "Kabungula@fifa.com", Phone ="244-344-3456", Image = "https://s3.india.com/wp-content/uploads/2020/06/Cristiano-Ronaldo-becomes-football%E2%80%99s-first-billionaire-beating-Lionel-Messi%C2%A9Twitter.jpg"},

                new User {Id = 3, FirstName="Flavio", LastName= "Amado", Email = "Flavio@fifa.com", Phone ="244-344-3456", Image = "https://www.zerozero.pt/img/treinadores/271/554271_med__20190306164158_flavio_amado.jpg"}
  

            };
        
            return User;
        }
    }
}