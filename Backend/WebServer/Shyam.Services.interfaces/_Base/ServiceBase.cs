using Shyam.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace Shyam.Services.interfaces._Base
{
    public abstract class ServiceBase : Disposable
    {
        protected ILogger Logger { get; private set; }
        protected IMapper Mapper { get; private set; }
        protected ServiceBase(ILogger logger, IMapper mapper)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        protected override void Dispose(bool disposing)
        {
            if (Disposed)
                return;
            if (disposing)
            {
                Logger = null;
                Mapper = null;
            }
            base.Dispose(disposing);
        }
    }
}
