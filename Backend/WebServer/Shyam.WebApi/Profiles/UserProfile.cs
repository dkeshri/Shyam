using Shyam.Data.Entities;
using Shyam.Services.Models._auth;
using Shyam.Services.Models;
using Shyam.WebApi.Dtos;
using AutoMapper;

namespace Shyam.WebApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCredientialsDto, UserCredientials>().ReverseMap();
        }
    }
}
