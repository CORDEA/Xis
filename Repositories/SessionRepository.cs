using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xis.Models;

namespace Xis.Repositories
{
    public class SessionRepository
    {
        private readonly HttpClient _httpClient;

        public SessionRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserSession> Create(string slug, string token)
        {
            // TODO
            _httpClient.BaseAddress = new Uri("");
            return await _httpClient.GetFromJsonAsync<UserSession>("");
        }
    }
}
