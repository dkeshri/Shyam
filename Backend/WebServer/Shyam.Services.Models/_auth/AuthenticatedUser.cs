using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Models._auth
{
    public class AuthenticatedUser
    {
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}
