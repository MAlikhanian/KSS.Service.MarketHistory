using KSS.Repository.IRepository;
using KSS.Repository.Repository;
using KSS.Service.IService;
using KSS.Service.Service;
using Microsoft.EntityFrameworkCore;
using KSS.Data.DbContexts;

namespace KSS.Api.ServiceExtention
{
    public static class MarketHistoryServiceExtention
    {
        public static IServiceCollection AddMarketHistoryServiceExtention(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("ConnectionStrings")["DefaultConnection"];

            services.AddDbContext<MainDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IAssetPriceHistoryRepository, AssetPriceHistoryRepository>();
            services.AddScoped<IAssetPriceHistoryService, AssetPriceHistoryService>();
            services.AddScoped<IMarketIndexRepository, MarketIndexRepository>();
            services.AddScoped<IMarketIndexService, MarketIndexService>();
            services.AddScoped<IMarketIndexTranslationRepository, MarketIndexTranslationRepository>();
            services.AddScoped<IMarketIndexTranslationService, MarketIndexTranslationService>();
            services.AddScoped<IMarketIndexHistoryRepository, MarketIndexHistoryRepository>();
            services.AddScoped<IMarketIndexHistoryService, MarketIndexHistoryService>();

            return services;
        }
    }
}
