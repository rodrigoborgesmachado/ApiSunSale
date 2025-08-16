using MainDto = ApiSunSale.Application.DTO.LicencassunsaleproDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.LicencassunsaleproViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class LicencassunsaleproProfile : AutoMapper.Profile
    {
        public LicencassunsaleproProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
