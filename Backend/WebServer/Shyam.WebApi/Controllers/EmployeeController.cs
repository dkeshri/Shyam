using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shyam.Services.interfaces.Interfaces;
using Shyam.WebApi.Controllers._base;
using Shyam.WebApi.Dtos;

namespace Shyam.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ApiControllerBase<EmployeeController,IEmployeeService>
    {
        public EmployeeController(ILogger<EmployeeController> logger,IMapper mapper,IEmployeeService employeeService)
            :base(logger,mapper,employeeService)
        {
            
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDto>> Get()
        {
            var employees = ControllerService.GetEmployees();
            return Ok(Mapper.Map<IEnumerable<EmployeeDto>>(employees));
        }
    }
}
