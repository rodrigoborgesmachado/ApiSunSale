using MainDto = ApiSunSale.Application.DTO.LoggerDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.LoggerViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class LoggerProfile : AutoMapper.Profile
    {
        public LoggerProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
