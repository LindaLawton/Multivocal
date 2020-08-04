using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace Multivocal.Config
{
    public static class MultivocalBuilderExtensions
    {
        public static IApplicationBuilder UseMultivocal(this IApplicationBuilder app)
        {
         
            app.Validate();

            app.UseMiddleware<BaseUrlMiddleware>();
            
            app.UseMiddleware<MultivocalMiddleware>();
            
            return app;
        }
        
        internal static void Validate(this IApplicationBuilder app)
        {
            var loggerFactory = app.ApplicationServices.GetService(typeof(ILoggerFactory)) as ILoggerFactory;
            if (loggerFactory == null) throw new ArgumentNullException(nameof(loggerFactory));

            var logger = loggerFactory.CreateLogger("Multivocal.Startup");
            logger.LogInformation("Starting Multivocal version {version}", FileVersionInfo.GetVersionInfo(typeof(MultivocalMiddleware).Assembly.Location).ProductVersion);
        }
    }
}