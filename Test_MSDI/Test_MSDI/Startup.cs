using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using Test_MSDI.Models;
using Test_MSDI.Services;

namespace Test_MSDI
{
    /// <summary>
    /// All the Host Builder and DI stuff can be found here.
    /// </summary>
    public static class Startup
    {
        /// <summary>
        /// Init the HostBuilder and Config.
        /// </summary>
        /// <param name="nativeConfigureServices">Pass in an Action to allow DI config from a platform init.</param>
        public static void Init(Action<HostBuilderContext, IServiceCollection> nativeConfigureServices)
        {
            //There are a few ways to config the Host and the following is what works best for XF.
            //While the core of Host is cross platform the rest of the extensions still assume a web project so many errors.
            var host = Host.CreateDefaultBuilder()
                .ConfigureLogging(logging => logging.AddSimpleConsole(options =>
                {
                    options.ColorBehavior = Microsoft.Extensions.Logging.Console.LoggerColorBehavior.Disabled;
                }))
                .ConfigureServices((hostBuilderctx, serviceCollection) =>
                {
                    nativeConfigureServices?.Invoke(hostBuilderctx, serviceCollection);
                    ConfigureServices(hostBuilderctx, serviceCollection);
                })
                .Build();

            App.ServiceProvider = host.Services;
        }

        static void ConfigureServices(HostBuilderContext ctx, IServiceCollection services)
        {
            //services.AddSingleton<IMyService, MyService>();
            services.AddSingleton<IDataStore<Item>, MockDataStore>();
        }
    }
}
