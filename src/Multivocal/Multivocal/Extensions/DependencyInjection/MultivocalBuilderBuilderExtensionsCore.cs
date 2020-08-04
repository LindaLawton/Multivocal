using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Multivocal.Config;
using Multivocal.Endpoints;

namespace Multivocal.Extensions.DependencyInjection
{
    /// <summary>
    /// Builder extension methods for registering core services
    /// </summary>
    public static class MultivocalBuilderBuilderExtensionsCore
    {
        /// <summary>
        /// Adds the default endpoints.
        /// </summary>
        /// <param name="builder">The builder</param>
        /// <returns></returns>
        public static IMultivocalBuilder AddDefaultEndpoints(this IMultivocalBuilder builder)
        {
            builder.Services.AddTransient<IEndpointRouter, EndpointRouter>();

            builder.AddEndpoint<MainWebHookEndPoint>("MultivocalWebHook", "/Multivocal");

            return builder;
        }
         
        /// <summary>
        /// Adds the endpoint.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="name">The name.</param>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static IMultivocalBuilder AddEndpoint<T>(this IMultivocalBuilder builder, string name, PathString path)
            where T : class, IEndpointHandler
        {
            builder.Services.AddTransient<T>();
            builder.Services.AddSingleton(new Endpoints.Endpoint(name, path, typeof(T)));
            return builder;
        }
    }
}