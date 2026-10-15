using KSS.Dto;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    public class MarketIndexTranslationController : BaseController<MarketIndexTranslation, MarketIndexTranslationDto, MarketIndexTranslationDto, MarketIndexTranslationDto>
    {
        public MarketIndexTranslationController(IMarketIndexTranslationService service) : base(service) { }
    }
}
