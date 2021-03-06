using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cronitor.Requests
{
    public class Pageable<TResponse>
    {
        [JsonProperty("page")]
        public int Page { get; set; } = 1;
        [JsonProperty("page_size")]
        public int PageSize { get; set; } = 50;
        [JsonProperty("total_monitor_count")]
        public int Total { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }

        public IEnumerable<TResponse> Result { get; set; } = new List<TResponse>();

        //TODO: Move this?
        [JsonProperty("monitors")]
        public IEnumerable<TResponse> Monitors { set => Result = value; }
        [JsonProperty("templates")]
        public IEnumerable<TResponse> Templates { set => Result = value; }
    }
}
