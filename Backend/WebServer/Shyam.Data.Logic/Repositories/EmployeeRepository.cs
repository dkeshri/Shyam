using Shyam.Data.Entities;
using Shyam.Data.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Data.Logic.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {
                    Id = 1,
                    Name = "Shyamy"
                },
                new Employee() {
                    Id = 3,
                    Name = "Deepak"
                }
            };

            return employees;
        }
    }
}
