using System;
using System.Collections.Generic;
using Cronitor.Extensions;

namespace Cronitor.Requests.Monitor
{
    public class GetActivitiesRequest : Request
    {
        public override string Endpoint { get; set; } = "monitors/:key/activity";
        public string MonitorKey { get; set; }

        public GetActivitiesRequest(string monitorKey)
        {
            MonitorKey = monitorKey;
        }

        public override Uri ToUri()
        {
            var dictionary = new Dictionary<string, string>
            {
                { ":key", MonitorKey }
            };

            return base.ToUri().Build(dictionary);
        }
    }
}
