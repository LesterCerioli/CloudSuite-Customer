using CloudSuite.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CloudSuite.Services.Customer.Api.Configurayions
{
	public static class DatabaseConfig
	{
		public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			if (services == null) throw new ArgumentNullException(nameof(services));

			services.AddDbContext<CustomerDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


		}
	}
}
