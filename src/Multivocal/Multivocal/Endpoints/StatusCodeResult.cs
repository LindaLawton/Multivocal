using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Multivocal.Config;

namespace Multivocal.Endpoints
{
    public class StatusCodeResult : IEndpointResult
    {
        public int StatusCode { get; }

        public StatusCodeResult(HttpStatusCode statusCode)
        {
            StatusCode = (int)statusCode;
        }

        /// <summary>
        /// Executes the result.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns></returns>
        public Task ExecuteAsync(HttpContext context)
        {
            context.Response.StatusCode = StatusCode;

            return Task.CompletedTask;
        }
    }
}