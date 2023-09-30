using FEx.WakaTime.Extensions;
using FEx.WakaTime.Models;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace FEx.WakaTime
{
    public class WakaTimeClient
    {
        private const string BaseUrl = "https://wakatime.com/api/v1";
        private readonly string _apiKey;

        public WakaTimeClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<UserResponse> GetCurrentUserAsync() =>
            await BaseUrl.AppendPathSegments("users", "current").Authenticate(_apiKey).GetJsonAsync<UserResponse>();

        public async Task<DurationResponse> GetDurationsAsync(string date) =>
            await BaseUrl.AppendPathSegments("users", "current", "durations")
                .SetQueryParam("date", date)
                .Authenticate(_apiKey)
                .GetJsonAsync<DurationResponse>();

        public async Task<StatsResponse> GetUserStatsAsync(string range) =>
            await BaseUrl.AppendPathSegments("users", "current", "stats", range)
                .Authenticate(_apiKey)
                .GetJsonAsync<StatsResponse>();
    }
}