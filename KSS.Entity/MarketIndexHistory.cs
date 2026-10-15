using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSS.Entity
{
    [Table("MarketIndexHistory", Schema = "dbo")]
    public class MarketIndexHistory
    {
        [Key]
        public Guid Id { get; set; }
        public int MarketIndexId { get; set; }
        public DateTime TradeDate { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal IndexValue { get; set; }
        [Column(TypeName = "decimal(8,4)")] public decimal? ChangePercent { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(MarketIndexId))]
        public MarketIndex MarketIndex { get; set; } = null!;
    }
}
