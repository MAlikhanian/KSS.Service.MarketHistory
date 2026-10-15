using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSS.Entity
{
    [Table("MarketIndexTranslation", Schema = "dbo")]
    public class MarketIndexTranslation
    {
        public int MarketIndexId { get; set; }
        public short LanguageId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey(nameof(MarketIndexId))]
        public MarketIndex MarketIndex { get; set; } = null!;
    }
}
