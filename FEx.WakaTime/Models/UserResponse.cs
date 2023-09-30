using Newtonsoft.Json;
using System;

namespace FEx.WakaTime.Models
{
    public class UserResponse
    {
        [JsonProperty("data")]
        public UserData Data { get; set; }
    }

    public class UserData
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }

        [JsonProperty("writes_only")]
        public bool WritesOnly { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("username")]
        public object Username { get; set; }

        [JsonProperty("share_all_time_badge")]
        public object ShareAllTimeBadge { get; set; }

        [JsonProperty("profile_url_escaped")]
        public Uri ProfileUrlEscaped { get; set; }

        [JsonProperty("show_machine_name_ip")]
        public bool ShowMachineNameIp { get; set; }

        [JsonProperty("bio")]
        public object Bio { get; set; }

        [JsonProperty("twitter_username")]
        public object TwitterUsername { get; set; }

        [JsonProperty("human_readable_website")]
        public object HumanReadableWebsite { get; set; }

        [JsonProperty("public_email")]
        public object PublicEmail { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("time_format_24hr")]
        public object TimeFormat24Hr { get; set; }

        [JsonProperty("invoice_id_format")]
        public string InvoiceIdFormat { get; set; }

        [JsonProperty("time_format_display")]
        public string TimeFormatDisplay { get; set; }

        [JsonProperty("public_profile_time_range")]
        public string PublicProfileTimeRange { get; set; }

        [JsonProperty("last_plugin")]
        public string LastPlugin { get; set; }

        [JsonProperty("is_onboarding_finished")]
        public bool IsOnboardingFinished { get; set; }

        [JsonProperty("needs_payment_method")]
        public bool NeedsPaymentMethod { get; set; }

        [JsonProperty("color_scheme")]
        public string ColorScheme { get; set; }

        [JsonProperty("share_last_year_days")]
        public object ShareLastYearDays { get; set; }

        [JsonProperty("is_email_public")]
        public bool IsEmailPublic { get; set; }

        [JsonProperty("weekday_start")]
        public long WeekdayStart { get; set; }

        [JsonProperty("is_hireable")]
        public bool IsHireable { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("logged_time_public")]
        public bool LoggedTimePublic { get; set; }

        [JsonProperty("languages_used_public")]
        public bool LanguagesUsedPublic { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("photo_public")]
        public bool PhotoPublic { get; set; }

        [JsonProperty("default_dashboard_range")]
        public string DefaultDashboardRange { get; set; }

        [JsonProperty("meetings_over_coding")]
        public bool MeetingsOverCoding { get; set; }

        [JsonProperty("has_premium_features")]
        public bool HasPremiumFeatures { get; set; }

        [JsonProperty("github_username")]
        public object GithubUsername { get; set; }

        [JsonProperty("has_basic_features")]
        public bool HasBasicFeatures { get; set; }

        [JsonProperty("modified_at")]
        public DateTimeOffset ModifiedAt { get; set; }

        [JsonProperty("is_email_confirmed")]
        public bool IsEmailConfirmed { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("photo")]
        public Uri Photo { get; set; }

        [JsonProperty("website")]
        public object Website { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }

        [JsonProperty("last_plugin_name")]
        public string LastPluginName { get; set; }

        [JsonProperty("linkedin_username")]
        public object LinkedinUsername { get; set; }

        [JsonProperty("last_project")]
        public string LastProject { get; set; }

        [JsonProperty("durations_slice_by")]
        public string DurationsSliceBy { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("last_heartbeat_at")]
        public DateTimeOffset LastHeartbeatAt { get; set; }
    }
}