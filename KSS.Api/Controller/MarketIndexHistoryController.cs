using KSS.Dto;
using KSS.Helper.CustomAttribute;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    [PermissionGroup("MarketIndexHistory")]
    public class MarketIndexHistoryController : BaseController<MarketIndexHistory, MarketIndexHistoryDto, MarketIndexHistoryAddDto, MarketIndexHistoryDto>
    {
        public MarketIndexHistoryController(IMarketIndexHistoryService service) : base(service) { }
    }
}
