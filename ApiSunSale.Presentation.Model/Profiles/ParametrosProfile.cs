using MainDto = ApiSunSale.Application.DTO.ParametrosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ParametrosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ParametrosProfile : AutoMapper.Profile
    {
        public ParametrosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
