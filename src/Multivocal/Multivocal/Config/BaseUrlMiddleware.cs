using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Multivocal.Extensions;

namespace Multivocal.Config
{
    public class BaseUrlMiddleware
    {
        private readonly RequestDelegate _next;

        public BaseUrlMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var request = context.Request;
            if (context == null) throw new ArgumentNullException(nameof(context));

            context.Items[Constants.EnvironmentKeys.MultivocalBasePath] = request.PathBase.Value.RemoveTrailingSlash();
            await _next(context);
        }
    }
}