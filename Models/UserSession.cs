using System.Text.Json.Serialization;

namespace Xis.Models
{
    public class UserSession
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; }

        public UserSession(string accessToken)
        {
            AccessToken = accessToken;
        }
    }
}
