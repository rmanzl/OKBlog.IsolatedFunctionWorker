using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNet5.IsolatedFunctionWorker.Base
{
    public interface IWorkerStartup
    {
        void ConfigureServices(IConfiguration configuration, IServiceCollection services);
    }
}
