using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class MarketIndexTranslationService : BaseService<MarketIndexTranslation, MarketIndexTranslationDto, MarketIndexTranslationDto, MarketIndexTranslationDto>, IMarketIndexTranslationService
    {
        public MarketIndexTranslationService(IMapper mapper, IMarketIndexTranslationRepository repository) : base(mapper, repository) { }
    }
}
