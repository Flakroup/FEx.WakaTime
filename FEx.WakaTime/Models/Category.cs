using Newtonsoft.Json;
using System;

namespace FEx.WakaTime.Models
{
    public class Category
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("total_seconds")]
        public double TotalSeconds { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("digital")]
        public string Digital { get; set; }

        [JsonProperty("decimal")]
        public string Decimal { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("hours")]
        public long Hours { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("machine_name_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MachineNameId { get; set; }
    }
}