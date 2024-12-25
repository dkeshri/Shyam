using AutoMapper;
using Shyam.Data.Entities;
using Shyam.Services.Models._auth;
using Shyam.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Logic.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserServiceModel, User>().ReverseMap();
            CreateMap<UserModel, User>().ReverseMap();
        }
    }
}
