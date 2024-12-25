using Shyam.Services.Models._auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.interfaces
{
    public interface ITokenService
    {
        public string CreateToken(UserModel user);
    }
}
