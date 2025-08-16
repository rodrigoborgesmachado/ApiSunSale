using MainDto = ApiSunSale.Application.DTO.TabelaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TabelaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TabelaProfile : AutoMapper.Profile
    {
        public TabelaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
