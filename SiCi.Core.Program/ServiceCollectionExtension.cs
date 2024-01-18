using SiCi.Core.Service.Services;
using SiCi.Repository;

namespace SiCi.Core.Program;

internal static class ServiceCollectionExtension
{
	internal static void AddRepositories(this IServiceCollection serviceCollection)
	{
		serviceCollection.AddSingleton<CompanyRepository>();
		serviceCollection.AddSingleton<PriceRepository>();
		serviceCollection.AddSingleton<ProductRepository>();
		serviceCollection.AddSingleton<ShopRepository>();
	}

	internal static void AddServices(this IServiceCollection serviceCollection)
	{
		serviceCollection.AddSingleton<CompanyService>();
		serviceCollection.AddSingleton<PriceService>();
		serviceCollection.AddSingleton<ProductService>();
		serviceCollection.AddSingleton<ShopService>();
	}
}
