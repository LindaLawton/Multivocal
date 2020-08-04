using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Multivocal.Config;

namespace Multivocal.Endpoints
{
    internal class MainWebHookEndPoint : MainWebHookEndPointBase
    {
        private readonly ILogger<MainWebHookEndPoint> _logger;

        public MainWebHookEndPoint(
            ILogger<MainWebHookEndPoint> logger)
            : base(logger)
        {
            _logger = logger;
        }

        public override async Task<IEndpointResult> ProcessAsync(HttpContext context)
        {
            if (!HttpMethods.IsPost(context.Request.Method))
            {
                _logger.LogWarning("Invalid HTTP method for multivocal web-hook endpoint.");
                return new StatusCodeResult(HttpStatusCode.MethodNotAllowed);
            }

            _logger.LogDebug("Start Web hook call back request");

            return await ProcessMainWebHookAsync(context);

        }
        
        private async Task<IEndpointResult> ProcessMainWebHookAsync(HttpContext context)
        {
            _logger.LogDebug("Start multivocal request");
          

            // generate response
           // _logger.LogTrace("Calling into multivocal response generator: {type}", _responseGenerator.GetType().FullName);
            //var response = await _responseGenerator.ProcessAsync(validationResult);

            _logger.LogDebug("End userinfo request");
            return new MainWebHookResult();
        }
        
        
    }
}