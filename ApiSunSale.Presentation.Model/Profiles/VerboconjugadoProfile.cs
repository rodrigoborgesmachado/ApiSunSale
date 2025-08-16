using MainDto = ApiSunSale.Application.DTO.VerboconjugadoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.VerboconjugadoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class VerboconjugadoProfile : AutoMapper.Profile
    {
        public VerboconjugadoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
