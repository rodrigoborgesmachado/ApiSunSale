using MainDto = ApiSunSale.Application.DTO.CodigostableDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.CodigostableViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class CodigostableProfile : AutoMapper.Profile
    {
        public CodigostableProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
