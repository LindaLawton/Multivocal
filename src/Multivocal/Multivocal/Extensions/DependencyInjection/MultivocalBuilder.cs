using System;
using Microsoft.Extensions.DependencyInjection;

namespace Multivocal.Extensions.DependencyInjection
{
    /// <summary>
    /// DI configuration Multivocal helper class
    /// </summary>
    public class MultivocalBuilder : IMultivocalBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultivocalBuilder"/> class.
        /// </summary>
        /// <param name="services">The services</param>
        /// <exception cref="System.ArgumentNullException">services</exception>
        public MultivocalBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }
        
        public IServiceCollection Services { get; }
    }
}