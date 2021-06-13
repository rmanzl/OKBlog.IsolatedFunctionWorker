using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace DotNet5.IsolatedFunctionWorker.Base
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseStartup<T>(this IHostBuilder hostBuilder)
            where T : IWorkerStartup, new()
        {
            IConfiguration configuration = null;
            hostBuilder.ConfigureAppConfiguration(builder =>
            {
                configuration = builder.Build();
            });

            hostBuilder.ConfigureServices(services =>
            {
                new T().ConfigureServices(configuration, services);
            });
            return hostBuilder;
        }
    }
}
