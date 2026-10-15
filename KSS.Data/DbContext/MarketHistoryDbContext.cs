using Microsoft.EntityFrameworkCore;
using KSS.Entity;

namespace KSS.Data.DbContexts
{
    public partial class MainDbContext
    {
        public DbSet<AssetPriceHistory> AssetPriceHistories { get; set; }
        public DbSet<MarketIndex> MarketIndexes { get; set; }
        public DbSet<MarketIndexTranslation> MarketIndexTranslations { get; set; }
        public DbSet<MarketIndexHistory> MarketIndexHistories { get; set; }
    }
}
