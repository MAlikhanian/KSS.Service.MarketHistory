using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSS.Entity
{
    [Table("AssetPriceHistory", Schema = "dbo")]
    public class AssetPriceHistory
    {
        [Key]
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public DateTime TradeDate { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal OpenPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal HighPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal LowPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal ClosePrice { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal FinalPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal? YesterdayPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")] public decimal? FirstPrice { get; set; }
        public long Volume { get; set; }
        [Column(TypeName = "decimal(20,2)")] public decimal Value { get; set; }
        public int TradeCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
