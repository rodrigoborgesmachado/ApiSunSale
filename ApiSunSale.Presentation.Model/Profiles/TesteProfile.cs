using MainDto = ApiSunSale.Application.DTO.TesteDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TesteViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TesteProfile : AutoMapper.Profile
    {
        public TesteProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
