using Newtonsoft.Json;
using System;

namespace FEx.WakaTime.Models
{
    public class BestDay
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("total_seconds")]
        public double TotalSeconds { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("modified_at")]
        public DateTimeOffset ModifiedAt { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}