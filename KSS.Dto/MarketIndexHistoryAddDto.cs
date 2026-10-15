namespace KSS.Dto
{
    public class MarketIndexHistoryAddDto
    {
        public int MarketIndexId { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal IndexValue { get; set; }
        public decimal? ChangePercent { get; set; }
    }
}
