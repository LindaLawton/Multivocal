using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Multivocal.Config;

namespace Multivocal.Endpoints
{
    internal abstract class MainWebHookEndPointBase : IEndpointHandler
    {
        private readonly ILogger _logger;

        protected MainWebHookEndPointBase(
            ILogger<MainWebHookEndPointBase> logger)
        {
            _logger = logger;
        }
        public abstract Task<IEndpointResult> ProcessAsync(HttpContext context);

    }
}