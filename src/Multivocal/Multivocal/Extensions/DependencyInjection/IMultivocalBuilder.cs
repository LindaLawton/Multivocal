using Microsoft.Extensions.DependencyInjection;

namespace Multivocal.Extensions.DependencyInjection
{
    /// <summary>
    /// Builder Interface for Multivocal
    /// </summary>
    public interface IMultivocalBuilder
    {
        IServiceCollection Services { get; }
    }
}