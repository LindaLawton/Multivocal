using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Multivocal.Config;

namespace Multivocal.Endpoints
{
    internal class MainWebHookResult : IEndpointResult
    {
        

        public MainWebHookResult()
        {
            
        }

        public async Task ExecuteAsync(HttpContext context)
        {

            await context.Response.WriteAsync("Hello from multivocal middlewear");
        }
    }
}