using DotNet5.IsolatedFunctionWorker.Base;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace DotNet5.IsolatedFunctionWorker
{
    public class Startup : IWorkerStartup
    {
        public void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetryWorkerService();

            services.ConfigureJsonSerializerWeb();
        }
    }
}
