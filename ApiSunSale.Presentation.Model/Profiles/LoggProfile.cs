using MainDto = ApiSunSale.Application.DTO.LoggDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.LoggViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class LoggProfile : AutoMapper.Profile
    {
        public LoggProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
