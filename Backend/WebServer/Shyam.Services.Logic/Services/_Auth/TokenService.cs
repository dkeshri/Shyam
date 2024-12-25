using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Shyam.Services.Extensions;
using Shyam.Services.interfaces;
using Shyam.Services.interfaces._Base;
using Shyam.Services.Models._auth;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Logic.Services._Auth
{
    internal class TokenService : ServiceBase, ITokenService
    {
        private SecurityKey TokenSecurityKey { get; }
        private int TokenExpiresInSeconds { get; }
        public TokenService(ILogger<TokenService> logger, IMapper mapper,IConfiguration configuration): base(logger, mapper)
        {
            var tokenSecret = configuration.GetTokenSecret();
            TokenSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
            TokenExpiresInSeconds = configuration.GetTokenExpireInSec();
        }

        public string CreateToken(UserModel user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,user.Username),
                new Claim(ClaimTypes.NameIdentifier,Convert.ToString(user.Id))
            };

            //claims.Add(new Claim(ClaimTypes.Role, user.Role));

            var signingCredientials = new SigningCredentials(TokenSecurityKey, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddSeconds(TokenExpiresInSeconds),
                SigningCredentials = signingCredientials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
