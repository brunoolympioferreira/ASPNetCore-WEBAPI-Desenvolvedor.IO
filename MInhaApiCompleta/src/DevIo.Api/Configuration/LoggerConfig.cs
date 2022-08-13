
using DevIO.Api.Extensions;

namespace DevIo.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "98458e8a803742e3a410759527d2a85b";
                o.LogId = new Guid("a4c67224-709e-4e15-bbae-eee109f382c2");
            });

            services.AddHealthChecks()
                .AddElmahIoPublisher(options =>
                {
                    options.ApiKey = "98458e8a803742e3a410759527d2a85b";
                    options.LogId = new Guid("a4c67224-709e-4e15-bbae-eee109f382c2");
                    options.HeartbeatId = "API Fornecedores";

                })
                .AddCheck("Produtos", new SqlServerHealthCheck(configuration.GetConnectionString("DefaultConnection")));
                //.AddSqlServer(configuration.GetConnectionString("DefaultConnection"), name: "BancoSQL");
                

            services.AddHealthChecksUI()
                .AddSqlServerStorage(configuration.GetConnectionString("DefaultConnection"));

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}
