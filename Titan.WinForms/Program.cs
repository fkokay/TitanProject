using DevExpress.CodeParser;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraWaitForm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Titan.Data;
using Titan.WinForms.UserControls;
using Titan.WinForms.Views;

namespace Titan.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var mainForm = services.GetRequiredService<MainView>();
                Application.Run(mainForm);
            }
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Connection string
                    var connectionString =
                        "Server=DESKTOP-QUF2ORT;Database=TitanDb;Trusted_Connection=True;TrustServerCertificate=True;";

                    // DbContext
                    services.AddDbContext<TitanContext>(options =>
                    {
                        options.UseSqlServer(connectionString);
                    }, ServiceLifetime.Transient);

                    // Formlar DI üzerinden çalışır
                    services.AddScoped<MainView>();
                    services.AddScoped<CustomerListView>();
                    services.AddScoped<CustomerListModalView>();
                    services.AddScoped<CustomerView>();
                    services.AddScoped<ItemListView>();
                    services.AddScoped<ItemView>();
                    services.AddScoped<CurrencyListView>();
                    services.AddScoped<CurrencyView>();
                    services.AddScoped<ExchangeRateListView>();
                    services.AddScoped<UnitListView>();
                    services.AddScoped<UnitView>();
                    services.AddScoped<WarehouseListView>();
                    services.AddScoped<WarehouseView>();
                    services.AddScoped<QuickSaleView>();
                    services.AddScoped<CustomerTransactionListView>();
                    services.AddScoped<StockTransactionListView>();
                    services.AddScoped<InvoiceListView>();
                    services.AddScoped<InvoiceView>();
                    services.AddScoped<CustomerTransactionListModalView>();
                });
        }
    }
}
