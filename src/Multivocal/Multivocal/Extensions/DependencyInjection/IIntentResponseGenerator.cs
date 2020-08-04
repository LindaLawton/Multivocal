namespace Multivocal.Extensions.DependencyInjection
{
    public interface IIntentResponseGenerator
    {
        string DisplayName { get; }

        string GenerateResponse();
    }
}