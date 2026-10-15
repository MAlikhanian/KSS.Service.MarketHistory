using AutoMapper;
using KSS.Entity;
using KSS.Dto;

namespace KSS.Api.MappingProfile
{
    public class BaseMappingProfile : Profile
    {
        public BaseMappingProfile()
        {
            CreateMap<AssetPriceHistory, AssetPriceHistoryDto>().ReverseMap();
            CreateMap<AssetPriceHistoryAddDto, AssetPriceHistory>().ReverseMap();
            CreateMap<MarketIndex, MarketIndexDto>().ReverseMap();
            CreateMap<MarketIndexTranslation, MarketIndexTranslationDto>().ReverseMap();
            CreateMap<MarketIndexHistory, MarketIndexHistoryDto>().ReverseMap();
            CreateMap<MarketIndexHistoryAddDto, MarketIndexHistory>().ReverseMap();
        }
    }
}
