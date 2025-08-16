using MainDto = ApiSunSale.Application.DTO.RecuperasenhaconcursandoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.RecuperasenhaconcursandoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RecuperasenhaconcursandoProfile : AutoMapper.Profile
    {
        public RecuperasenhaconcursandoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
