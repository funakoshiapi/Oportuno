using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Oportuno.Entities;
using Oportuno.Data;
using System;
using AutoMapper;

namespace Oportuno.Contollers
{   
    
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IOportunoRepo _userRepository;
        private readonly IMapper _mapper;

        // this constructor is resiving the value that is being injected by the dependency injection system
        public UserController(IOportunoRepo userRepository, IMapper mapper)
        {
            _userRepository = userRepository ??
                throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
      
        
        //Get api/user
        [HttpGet]
        public ActionResult < IEnumerable<User> > GetAllUsers()
        {
            var User = _userRepository.GetAllUsers();

            return Ok(User);
        }

        //Get api/User/{id}
        [HttpGet("{userId}")]
        public ActionResult <IEnumerable<User> > GetUserById(int userId)
        {
            var user = _userRepository.GetUserById(userId);

            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }


    }
}