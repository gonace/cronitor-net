using System;
using System.Collections.Generic;
using System.Net.Http;
using Cronitor.Extensions;

namespace Cronitor.Requests.Monitor
{
    public class DeleteRequest : Request
    {
        public override string Endpoint { get; set; } = "monitors/:key";
        public override HttpMethod Method => HttpMethod.Delete;
        public string MonitorKey { get; set; }

        public DeleteRequest(string monitorKey)
        {
            MonitorKey = monitorKey;
        }

        public override Uri ToUri()
        {
            var dictionary = new Dictionary<string, string>
            {
                { ":key", MonitorKey },
            };

            return base.ToUri().Build(dictionary);
        }
    }
}
