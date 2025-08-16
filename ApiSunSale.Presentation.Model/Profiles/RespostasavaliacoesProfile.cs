using MainDto = ApiSunSale.Application.DTO.RespostasavaliacoesDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.RespostasavaliacoesViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RespostasavaliacoesProfile : AutoMapper.Profile
    {
        public RespostasavaliacoesProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
