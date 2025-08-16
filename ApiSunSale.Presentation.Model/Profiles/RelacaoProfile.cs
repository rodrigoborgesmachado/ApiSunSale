using MainDto = ApiSunSale.Application.DTO.RelacaoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.RelacaoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RelacaoProfile : AutoMapper.Profile
    {
        public RelacaoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
