using Shyam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Data.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAllEmployee();
    }
}
