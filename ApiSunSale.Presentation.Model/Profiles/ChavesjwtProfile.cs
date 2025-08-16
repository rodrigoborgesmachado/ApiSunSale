using MainDto = ApiSunSale.Application.DTO.ChavesjwtDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ChavesjwtViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ChavesjwtProfile : AutoMapper.Profile
    {
        public ChavesjwtProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
