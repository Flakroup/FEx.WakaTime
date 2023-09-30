using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FEx.WakaTime.Models
{
    public class DurationResponse
    {
        [JsonProperty("data")]
        public List<DurationData> Data { get; set; }

        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("end")]
        public DateTimeOffset End { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}