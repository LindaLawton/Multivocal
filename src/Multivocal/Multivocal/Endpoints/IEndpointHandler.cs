using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Multivocal.Endpoints
{
    public interface IEndpointHandler
    {
        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="context">The HTTP context</param>
        /// <returns></returns>
        Task<IEndpointResult> ProcessAsync(HttpContext context);
    }
}