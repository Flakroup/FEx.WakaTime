using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FEx.WakaTime.Models
{
    public class StatsData
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("end")]
        public DateTimeOffset End { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }

        [JsonProperty("writes_only")]
        public bool WritesOnly { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("holidays")]
        public long Holidays { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("modified_at")]
        public DateTimeOffset ModifiedAt { get; set; }

        [JsonProperty("human_readable_total_including_other_language")]
        public string HumanReadableTotalIncludingOtherLanguage { get; set; }

        [JsonProperty("editors")]
        public List<Category> Editors { get; set; }

        [JsonProperty("total_seconds")]
        public double TotalSeconds { get; set; }

        [JsonProperty("languages")]
        public List<Category> Languages { get; set; }

        [JsonProperty("operating_systems")]
        public List<Category> OperatingSystems { get; set; }

        [JsonProperty("daily_average_including_other_language")]
        public long DailyAverageIncludingOtherLanguage { get; set; }

        [JsonProperty("is_already_updating")]
        public bool IsAlreadyUpdating { get; set; }

        [JsonProperty("human_readable_daily_average")]
        public string HumanReadableDailyAverage { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("best_day")]
        public BestDay BestDay { get; set; }

        [JsonProperty("days_including_holidays")]
        public long DaysIncludingHolidays { get; set; }

        [JsonProperty("daily_average")]
        public long DailyAverage { get; set; }

        [JsonProperty("dependencies")]
        public List<Category> Dependencies { get; set; }

        [JsonProperty("human_readable_daily_average_including_other_language")]
        public string HumanReadableDailyAverageIncludingOtherLanguage { get; set; }

        [JsonProperty("is_stuck")]
        public bool IsStuck { get; set; }

        [JsonProperty("is_up_to_date")]
        public bool IsUpToDate { get; set; }

        [JsonProperty("days_minus_holidays")]
        public long DaysMinusHolidays { get; set; }

        [JsonProperty("machines")]
        public List<Category> Machines { get; set; }

        [JsonProperty("projects")]
        public List<Category> Projects { get; set; }

        [JsonProperty("human_readable_total")]
        public string HumanReadableTotal { get; set; }

        [JsonProperty("percent_calculated")]
        public long PercentCalculated { get; set; }

        [JsonProperty("is_up_to_date_pending_future")]
        public bool IsUpToDatePendingFuture { get; set; }

        [JsonProperty("total_seconds_including_other_language")]
        public double TotalSecondsIncludingOtherLanguage { get; set; }

        [JsonProperty("username")]
        public object Username { get; set; }

        [JsonProperty("is_including_today")]
        public bool IsIncludingToday { get; set; }

        [JsonProperty("human_readable_range")]
        public string HumanReadableRange { get; set; }

        [JsonProperty("is_coding_activity_visible")]
        public bool IsCodingActivityVisible { get; set; }

        [JsonProperty("is_other_usage_visible")]
        public bool IsOtherUsageVisible { get; set; }
    }
}