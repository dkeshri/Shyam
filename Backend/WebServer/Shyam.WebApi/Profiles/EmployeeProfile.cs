using AutoMapper;
using Shyam.Services.Models;
using Shyam.WebApi.Dtos;

namespace Shyam.WebApi.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDto, EmployeeServiceModel>().ReverseMap();
        }
        
    }
}
