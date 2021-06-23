using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Services.Interfaces;
using Services.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.UI.ViewModels;
using WPF.UI.Views;

namespace WPF.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;

        public static IServiceProvider ServiceProvider { get; private set; }

        public App()
        {
            host = Host.CreateDefaultBuilder().UseSerilog((host, loggerConfiguration) =>
            {
                loggerConfiguration
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("Logs\\log.txt",
                    rollOnFileSizeLimit: true,
                    fileSizeLimitBytes: 1048576,
                    retainedFileCountLimit: 3,
                    outputTemplate: "{Timestamp:dd/MM/yyyy HH:mm:ss} [{Level:u3}] {Message}{NewLine:1}{Exception:1}");
            }).ConfigureAppConfiguration((context, builder) =>
            {
                builder.AddJsonFile("appsettings.json", optional: true);
            }).ConfigureServices((context, services) =>
            {
                ConfigureServices(context.Configuration, services);
            }).Build();

            ServiceProvider = host.Services;
        }

        private void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            //Service dependency injections
            services.AddSingleton<IInitializationService, InitializationService>();
            services.AddSingleton<IAccountService, AccountService>();
            services.AddSingleton<IStatisticsService, StatisticsService>();

            //ViewModel dependency injection
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<InitViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<AccountViewModel>();
            services.AddSingleton<StatisticsViewModel>();
            services.AddSingleton<HomeViewModel>();


            services.AddTransient<MainWindow>();
            services.AddTransient<InitWindow>();
            services.AddTransient<HomeWindow>();
            //services.AddTransient<AccountPanel>();
            //services.AddTransient<StatisticsPanel>();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await host.StartAsync();

            var navigationService = ServiceProvider.GetRequiredService<MainWindow>();
            navigationService.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using (host)
            {
                await host.StopAsync(TimeSpan.FromSeconds(5));
            }

            base.OnExit(e);
        }
    }
}
