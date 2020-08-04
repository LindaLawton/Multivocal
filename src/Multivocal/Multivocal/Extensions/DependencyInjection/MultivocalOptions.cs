using System.Collections.Generic;

namespace Multivocal.Extensions.DependencyInjection
{
    public class MultivocalOptions
    {
        public List<IIntentResponseGenerator> Intents { get; set; }
    }
}