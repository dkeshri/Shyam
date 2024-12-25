﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using Shyam.Services.interfaces;
using Shyam.Services.interfaces._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Logic.Services._Auth
{
    internal class TokenService : ServiceBase, ITokenService
    {
        public TokenService(ILogger<TokenService> logger, IMapper mapper): base(logger, mapper)
        {
            
        }
    }
}
