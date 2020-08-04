using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Multivocal.Parser.ActionsOnGoogle;
using Newtonsoft.Json;

namespace Multivocal.Parser
{
    public class RequestParser
    {
        private readonly ILogger<RequestParser> _logger;

        public RequestParser(ILogger<RequestParser> logger)
        {
            _logger = logger;
        }

        public virtual async Task<ActionsOnGoogleFulfillmentWebhookRequest> ProcessAsync(string data)
        {
            _logger.LogDebug("Parsing request");

            return JsonConvert.DeserializeObject<ActionsOnGoogleFulfillmentWebhookRequest>(data);
        }

    }
}