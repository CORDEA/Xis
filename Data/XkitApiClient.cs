using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xis.Models;

namespace Xis.Data
{
    public class XkitApiClient
    {
        private const string BaseAddress = "https://{0}.xkit.co/api/platform_user";

        private readonly HttpClient _httpClient;

        public XkitApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserSession> CreateUserSession(string slug, string token)
        {
            _httpClient.BaseAddress = new Uri(string.Format(BaseAddress, slug));
            // TODO
            return await _httpClient.GetFromJsonAsync<UserSession>("");
        }
    }
}
