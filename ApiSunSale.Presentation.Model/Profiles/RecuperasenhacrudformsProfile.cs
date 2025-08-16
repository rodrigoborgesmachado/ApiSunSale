using MainDto = ApiSunSale.Application.DTO.RecuperasenhacrudformsDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.RecuperasenhacrudformsViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RecuperasenhacrudformsProfile : AutoMapper.Profile
    {
        public RecuperasenhacrudformsProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
