using Newtonsoft.Json;

namespace FEx.WakaTime.Models
{
    public class DurationData
    {
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }
    }
}