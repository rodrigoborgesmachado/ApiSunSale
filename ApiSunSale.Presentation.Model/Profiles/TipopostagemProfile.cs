using MainDto = ApiSunSale.Application.DTO.TipopostagemDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TipopostagemViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TipopostagemProfile : AutoMapper.Profile
    {
        public TipopostagemProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
