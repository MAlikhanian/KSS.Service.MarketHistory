using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class MarketIndexHistoryService : BaseService<MarketIndexHistory, MarketIndexHistoryDto, MarketIndexHistoryAddDto, MarketIndexHistoryDto>, IMarketIndexHistoryService
    {
        public MarketIndexHistoryService(IMapper mapper, IMarketIndexHistoryRepository repository) : base(mapper, repository) { }
    }
}
