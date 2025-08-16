using MainDto = ApiSunSale.Application.DTO.UsuarioconcursandoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.UsuarioconcursandoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class UsuarioconcursandoProfile : AutoMapper.Profile
    {
        public UsuarioconcursandoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
