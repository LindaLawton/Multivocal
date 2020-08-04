using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Multivocal.Extensions
{
    public static class HttpContextExtensions
    {
        public static async Task<string> GetBody(this HttpContext context)
        {
            var bodyStr = String.Empty;
            using (var reader = new StreamReader(context.Request.Body, Encoding.UTF8, true, 1024, true))
            {
                bodyStr = await reader.ReadToEndAsync();
            }

            return bodyStr;
        }
    }
}