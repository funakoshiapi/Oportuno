using System.Collections.Generic;
using Oportuno.Entities;

namespace Oportuno.Data
{   //Funakoshi Silva
    //List of method signatures being provided to consumer 
    public interface IOportunoRepo
    {
        Store GetStoreById(int id);
        User GetUserById (int id);
        IEnumerable<Store> GetAllStores();
        IEnumerable<User> GetAllUsers();
    }


}