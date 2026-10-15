using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class AssetPriceHistoryService : BaseService<AssetPriceHistory, AssetPriceHistoryDto, AssetPriceHistoryAddDto, AssetPriceHistoryDto>, IAssetPriceHistoryService
    {
        public AssetPriceHistoryService(IMapper mapper, IAssetPriceHistoryRepository repository) : base(mapper, repository) { }
    }
}
