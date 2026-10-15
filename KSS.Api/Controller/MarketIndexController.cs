using KSS.Dto;
using KSS.Helper.CustomAttribute;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    [PermissionGroup("MarketIndex")]
    public class MarketIndexController : BaseController<MarketIndex, MarketIndexDto, MarketIndexDto, MarketIndexDto>
    {
        public MarketIndexController(IMarketIndexService service) : base(service) { }
    }
}
