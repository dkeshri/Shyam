using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Models
{
    public class EmployeeServiceModel : EntityBaseServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
