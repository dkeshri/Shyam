using AutoMapper;
using Microsoft.Extensions.Logging;
using Shyam.Data.Interfaces.Repositories;
using Shyam.Services.interfaces._Base;
using Shyam.Services.interfaces.Interfaces;
using Shyam.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Logic
{
    internal class EmployeeService : ServiceBase, IEmployeeService
    {
        private IEmployeeRepository _repository;
        public EmployeeService(ILogger<EmployeeService> logger,IMapper mapper,IEmployeeRepository employeeRepository):base(logger,mapper)
        {
            _repository = employeeRepository;
        }
        public List<EmployeeServiceModel> GetEmployees()
        {
            List<EmployeeServiceModel> employeeServiceModels = Mapper.Map<List<EmployeeServiceModel>>(_repository.GetAllEmployee());


            return employeeServiceModels;
        }
    }
}
