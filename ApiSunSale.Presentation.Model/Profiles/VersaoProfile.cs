using MainDto = ApiSunSale.Application.DTO.VersaoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.VersaoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class VersaoProfile : AutoMapper.Profile
    {
        public VersaoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
