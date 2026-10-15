namespace KSS.Dto
{
    public class MarketIndexHistoryDto
    {
        public Guid Id { get; set; }
        public int MarketIndexId { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal IndexValue { get; set; }
        public decimal? ChangePercent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
