using KSS.Entity;
using KSS.Repository.IRepository;
using MarketHistoryDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class AssetPriceHistoryRepository : BaseRepository<MarketHistoryDbContext, AssetPriceHistory>, IAssetPriceHistoryRepository
    {
        public AssetPriceHistoryRepository(MarketHistoryDbContext dbContext) : base(dbContext) { }
    }
}
