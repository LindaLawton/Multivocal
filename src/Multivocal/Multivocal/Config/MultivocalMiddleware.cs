using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Multivocal.Endpoints;

namespace Multivocal.Config
{
    public class MultivocalMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes the HttpsRedirectionMiddleware
        /// </summary>
        /// <param name="next"></param>
        /// <param name="logger"></param>
        public MultivocalMiddleware(RequestDelegate next, ILogger<MultivocalMiddleware> logger)
        {
            _logger = logger;
            _next = next ?? throw new ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Invokes the main webhook middlewear
        /// </summary>
        /// <param name="context"></param>
        /// <param name="router"></param>
        /// <returns></returns>
        public  async Task Invoke(HttpContext context, IEndpointRouter router)
        {
            try
            {
                var endpoint = router.Find(context);
                if (endpoint != null)
                {
                    _logger.LogInformation("Invoking multivocal main webhook endpoint: {endpointType} for {url}",
                        endpoint.GetType().FullName, context.Request.Path.ToString());

                    var result = await endpoint.ProcessAsync(context);

                    if (result != null)
                    {
                        _logger.LogTrace("Invoking result: {type}", result.GetType().FullName);
                        await result.ExecuteAsync(context);
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception: {exception}", ex.Message);
                throw;
            }

            await _next(context);
        }

    }

   
}