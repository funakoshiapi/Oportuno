using System.Collections.Generic;
using Oportuno.Models;

namespace Oportuno.Data
{   //Funakoshi Silva
    //List of method signatures being provided to consumer 
    public interface IOportunoRepo
    {
        Store GetStoreById(int id);
        AppUser GetAppUserById (int id);
        IEnumerable<Store> GetAppStores();
        IEnumerable<AppUser> GetAppUsers();
    }


}