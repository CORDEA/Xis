using System.Threading.Tasks;
using Xis.Data;
using Xis.Models;

namespace Xis.Repositories
{
    public class SessionRepository
    {
        private readonly XkitApiClient _apiClient;

        public SessionRepository(XkitApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<UserSession> Create(string slug, string token)
        {
            return await _apiClient.CreateUserSession(slug, token);
        }
    }
}
