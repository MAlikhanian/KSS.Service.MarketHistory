using KSS.Entity;
using KSS.Repository.IRepository;
using MarketHistoryDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class MarketIndexTranslationRepository : BaseRepository<MarketHistoryDbContext, MarketIndexTranslation>, IMarketIndexTranslationRepository
    {
        public MarketIndexTranslationRepository(MarketHistoryDbContext dbContext) : base(dbContext) { }
    }
}
