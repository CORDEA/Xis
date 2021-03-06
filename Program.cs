using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xis.Data;
using Xis.Repositories;

namespace Xis
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<XkitApiClient>();
            builder.Services.AddSingleton<SessionRepository>();

            await builder.Build().RunAsync();
        }
    }
}
