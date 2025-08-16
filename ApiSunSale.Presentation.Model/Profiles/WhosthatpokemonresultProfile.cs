using MainDto = ApiSunSale.Application.DTO.WhosthatpokemonresultDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.WhosthatpokemonresultViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class WhosthatpokemonresultProfile : AutoMapper.Profile
    {
        public WhosthatpokemonresultProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
