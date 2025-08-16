using MainDto = ApiSunSale.Application.DTO.UsuariosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.UsuariosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class UsuariosProfile : AutoMapper.Profile
    {
        public UsuariosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
