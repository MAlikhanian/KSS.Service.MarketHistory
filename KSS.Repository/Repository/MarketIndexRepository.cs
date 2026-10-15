using KSS.Entity;
using KSS.Repository.IRepository;
using MarketHistoryDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class MarketIndexRepository : BaseRepository<MarketHistoryDbContext, MarketIndex>, IMarketIndexRepository
    {
        public MarketIndexRepository(MarketHistoryDbContext dbContext) : base(dbContext) { }
    }
}
