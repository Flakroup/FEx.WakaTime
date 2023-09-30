using Newtonsoft.Json;

namespace FEx.WakaTime.Models
{
    public class StatsResponse
    {
        [JsonProperty("data")]
        public StatsData StatsData { get; set; }
    }
}