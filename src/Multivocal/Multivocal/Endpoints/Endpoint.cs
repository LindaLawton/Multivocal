using System;
using Microsoft.AspNetCore.Http;

namespace Multivocal.Endpoints
{
    public class Endpoint
    {
        public string Name { get; set; }
        public PathString Path { get; set; }
        public Type Handler { get; set; }
        
        public Endpoint(string name, string path, Type handlerType)
        {
            Name = name;
            Path = path;
            Handler = handlerType;
        }
        
    }
    
}