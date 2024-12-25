using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Models._auth
{
    public class UserModel
    {
        public long Id { get; set; }
        public List<long> ShopIds { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
    }
}
