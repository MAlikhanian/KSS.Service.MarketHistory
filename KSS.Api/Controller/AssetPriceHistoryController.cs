using KSS.Dto;
using KSS.Helper.CustomAttribute;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    [PermissionGroup("AssetPriceHistory")]
    public class AssetPriceHistoryController : BaseController<AssetPriceHistory, AssetPriceHistoryDto, AssetPriceHistoryAddDto, AssetPriceHistoryDto>
    {
        public AssetPriceHistoryController(IAssetPriceHistoryService service) : base(service) { }
    }
}
