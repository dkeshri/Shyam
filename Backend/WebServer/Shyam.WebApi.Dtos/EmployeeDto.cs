using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.WebApi.Dtos
{
    public class EmployeeDto : EntityBaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
