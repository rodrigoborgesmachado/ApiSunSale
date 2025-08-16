using MainDto = ApiSunSale.Application.DTO.CartaocreditodevtoolsDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.CartaocreditodevtoolsViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class CartaocreditodevtoolsProfile : AutoMapper.Profile
    {
        public CartaocreditodevtoolsProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
