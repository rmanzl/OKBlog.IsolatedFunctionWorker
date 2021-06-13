using DotNet5.IsolatedFunctionWorker.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using Azure.Core.Serialization;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace DotNet5.IsolatedFunctionWorker
{
    public class Startup : IWorkerStartup
    {
        public void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddOptions<WorkerOptions>()
                .PostConfigure<IOptions<JsonSerializerOptions>>((workerOptions, _) =>
                {
                    workerOptions.Serializer = new JsonObjectSerializer(
                        new JsonSerializerOptions(JsonSerializerDefaults.Web));
                });
        }
    }
}
