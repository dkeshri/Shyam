using AutoMapper;
using Shyam.Data.Entities;
using Shyam.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Logic.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeServiceModel, Employee>().ReverseMap();
        }
    }
}
