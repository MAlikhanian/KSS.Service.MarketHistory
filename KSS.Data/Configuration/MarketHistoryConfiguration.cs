using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KSS.Entity;

namespace KSS.Data.Configuration
{
    public class AssetPriceHistoryConfiguration : IEntityTypeConfiguration<AssetPriceHistory>
    {
        public void Configure(EntityTypeBuilder<AssetPriceHistory> b)
        {
            b.HasIndex(x => x.AssetId);
            b.HasIndex(x => new { x.AssetId, x.TradeDate }).IsUnique();
        }
    }

    public class MarketIndexConfiguration : IEntityTypeConfiguration<MarketIndex>
    {
        public void Configure(EntityTypeBuilder<MarketIndex> b)
        {
            b.Property(x => x.IsActive).HasDefaultValue(true);
            b.HasIndex(x => x.Code).IsUnique();
            b.HasMany(x => x.Translations).WithOne(x => x.MarketIndex).HasForeignKey(x => x.MarketIndexId).OnDelete(DeleteBehavior.Cascade);
            b.HasMany(x => x.History).WithOne(x => x.MarketIndex).HasForeignKey(x => x.MarketIndexId).OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class MarketIndexTranslationConfiguration : IEntityTypeConfiguration<MarketIndexTranslation>
    {
        public void Configure(EntityTypeBuilder<MarketIndexTranslation> b)
        {
            b.HasKey(x => new { x.MarketIndexId, x.LanguageId });
        }
    }

    public class MarketIndexHistoryConfiguration : IEntityTypeConfiguration<MarketIndexHistory>
    {
        public void Configure(EntityTypeBuilder<MarketIndexHistory> b)
        {
            b.HasIndex(x => x.MarketIndexId);
            b.HasIndex(x => new { x.MarketIndexId, x.TradeDate }).IsUnique();
        }
    }
}
