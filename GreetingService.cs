using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

//DI
//Serilog
//settings
namespace PerfactConsoleApp
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> loggger;
        private readonly IConfiguration config;

        public GreetingService(ILogger<GreetingService> logger, IConfiguration config)
        {
            this.loggger = logger;
            this.config = config;
        }
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                loggger.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
