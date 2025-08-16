using MainDto = ApiSunSale.Application.DTO.ConfiguracaoemailDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ConfiguracaoemailViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ConfiguracaoemailProfile : AutoMapper.Profile
    {
        public ConfiguracaoemailProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
