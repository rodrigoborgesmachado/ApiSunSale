using MainDto = ApiSunSale.Application.DTO.AvaliacaoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.AvaliacaoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AvaliacaoProfile : AutoMapper.Profile
    {
        public AvaliacaoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
