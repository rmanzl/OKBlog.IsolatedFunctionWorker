using DotNet5.IsolatedFunctionWorker.Base;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace DotNet5.IsolatedFunctionWorker
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .UseStartup<Startup>()
                .Build();

            await host.RunAsync();
        }
    }
}