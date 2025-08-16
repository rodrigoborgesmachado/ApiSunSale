using MainDto = ApiSunSale.Application.DTO.SimuladosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.SimuladosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class SimuladosProfile : AutoMapper.Profile
    {
        public SimuladosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
