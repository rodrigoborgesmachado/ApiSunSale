using MainDto = ApiSunSale.Application.DTO.RecuperasenhaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.RecuperasenhaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RecuperasenhaProfile : AutoMapper.Profile
    {
        public RecuperasenhaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
