using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class MarketIndexService : BaseService<MarketIndex, MarketIndexDto, MarketIndexDto, MarketIndexDto>, IMarketIndexService
    {
        public MarketIndexService(IMapper mapper, IMarketIndexRepository repository) : base(mapper, repository) { }
    }
}
