using KSS.Entity;
using KSS.Repository.IRepository;
using MarketHistoryDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class MarketIndexHistoryRepository : BaseRepository<MarketHistoryDbContext, MarketIndexHistory>, IMarketIndexHistoryRepository
    {
        public MarketIndexHistoryRepository(MarketHistoryDbContext dbContext) : base(dbContext) { }
    }
}
