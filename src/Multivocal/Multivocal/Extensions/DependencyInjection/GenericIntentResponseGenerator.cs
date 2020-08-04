using System;

namespace Multivocal.Extensions.DependencyInjection
{
    public class GenericIntentResponseGenerator : IntentResponseGeneratorBase<string>, IIntentResponseGenerator
    {
        public string DisplayName { get; }
        
        public GenericIntentResponseGenerator(string displayName) : base(displayName)
        {
            DisplayName = displayName;
        }
        
        public string GenerateResponse()
        {
            throw new NotImplementedException();
        }

        
    }
}