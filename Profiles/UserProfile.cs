using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oportuno.Entities;

namespace Oportuno.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            // mapper uri
            // need to change user controller
            CreateMap<Entities.User, Models.UserDto>()
             .ForMember(
                   dest => dest.Name,
                   opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

        }
    }
}
