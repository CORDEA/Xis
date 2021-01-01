using System.Threading.Tasks;
using Xis.Data;

namespace Xis.Repositories
{
    public class SessionRepository
    {
        private readonly XkitApiClient _apiClient;

        public SessionRepository(XkitApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Create(string slug, string token)
        {
            await _apiClient.CreateUserSession(slug, token);
        }
    }
}
