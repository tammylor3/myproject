using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyEmployeesProject.Extensions
{
    public class ServiceExtensions
    {
        public static void ConfigureLoggerService (this IServiceCollection services) =>
        services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts => 
                opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>

                    b.MigrationAssembly("CompanyEmployees")));
    }
}

