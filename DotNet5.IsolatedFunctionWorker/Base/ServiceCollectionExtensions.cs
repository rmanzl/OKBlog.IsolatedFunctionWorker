using System.Text.Json;
using Azure.Core.Serialization;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DotNet5.IsolatedFunctionWorker.Base
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureJsonSerializerWeb(this IServiceCollection services)
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
