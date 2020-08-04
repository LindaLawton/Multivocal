using Microsoft.Extensions.DependencyInjection;

namespace Multivocal.Extensions.DependencyInjection
{
    public static class MultivocalServiceCollectionExtensions
    {
        /// <summary>
        /// Creates a builder for Multivocal
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IMultivocalBuilder AddMultivocalBuilder(this IServiceCollection services)
        {
            return new MultivocalBuilder(services);
        }
        
        /// <summary>
        /// Adds Multivocal.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IMultivocalBuilder AddMultivocal(this IServiceCollection services)
        {
            var builder = services.AddMultivocalBuilder();

            builder.AddDefaultEndpoints();

            return builder;
        }
    }
}