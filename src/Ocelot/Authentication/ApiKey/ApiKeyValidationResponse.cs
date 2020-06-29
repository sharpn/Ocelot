using System;
using System.Collections.Generic;

namespace Ocelot.Authentication.Extensions.ApiKey
{
    public class ApiKeyValidationResponse
    {
        public string Owner { get; }
        public IReadOnlyCollection<string> Scopes { get; }
    }
}
