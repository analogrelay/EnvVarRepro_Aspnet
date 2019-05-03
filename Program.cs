using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EnvVarRepro_Aspnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set up env vars
            Environment.SetEnvironmentVariable("HostName", "global.host");
            Environment.SetEnvironmentVariable("Logging__HostName", "logging.host");
            Environment.SetEnvironmentVariable("Metrics__HostName", "metrics.host");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
