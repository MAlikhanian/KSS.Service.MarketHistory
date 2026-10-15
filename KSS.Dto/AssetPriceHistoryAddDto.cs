namespace KSS.Dto
{
    public class AssetPriceHistoryAddDto
    {
        public Guid AssetId { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal ClosePrice { get; set; }
        public decimal FinalPrice { get; set; }
        public decimal? YesterdayPrice { get; set; }
        public decimal? FirstPrice { get; set; }
        public long Volume { get; set; }
        public decimal Value { get; set; }
        public int TradeCount { get; set; }
    }
}
