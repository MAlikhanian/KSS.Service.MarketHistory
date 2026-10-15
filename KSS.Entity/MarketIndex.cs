using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSS.Entity
{
    [Table("MarketIndex", Schema = "dbo")]
    public class MarketIndex
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Unicode(false)]
        public string Code { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        public ICollection<MarketIndexTranslation> Translations { get; set; } = new List<MarketIndexTranslation>();
        public ICollection<MarketIndexHistory> History { get; set; } = new List<MarketIndexHistory>();
    }
}
