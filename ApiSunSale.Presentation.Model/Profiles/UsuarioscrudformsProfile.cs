using MainDto = ApiSunSale.Application.DTO.UsuarioscrudformsDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.UsuarioscrudformsViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class UsuarioscrudformsProfile : AutoMapper.Profile
    {
        public UsuarioscrudformsProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
