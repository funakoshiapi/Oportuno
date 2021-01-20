using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Oportuno.Models;
using Oportuno.Data;

namespace Oportuno.Contollers
{   
    
    [Route("api/AppUser")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private  readonly MockOportunoRepo _repository = new MockOportunoRepo();
        
        //Get api/AppUser
        [HttpGet]
        public ActionResult < IEnumerable<AppUser> > GetAllAppUsers()
        {
            var appUsers = _repository.GetAppUsers();

            return Ok(appUsers);
        }
        //Get api/AppUser/{id}
        [HttpGet("{id}")]
        public ActionResult <IEnumerable<AppUser> > GetAllAppUserById(int id)
        {
            var appUser = _repository.GetAppUserById(id);

            return Ok(appUser);
        }


    }
}