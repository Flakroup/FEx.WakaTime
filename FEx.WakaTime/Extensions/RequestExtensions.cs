using Flurl;
using Flurl.Http;
using System;
using System.Text;

namespace FEx.WakaTime.Extensions
{
    public static class RequestExtensions
    {
        public static IFlurlRequest Authenticate(this Url url, string apiKey) =>
            url.WithHeader("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(apiKey))}");
    }
}