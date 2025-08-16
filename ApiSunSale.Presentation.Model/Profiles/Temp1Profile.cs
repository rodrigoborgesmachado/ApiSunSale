using MainDto = ApiSunSale.Application.DTO.Temp1DTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.Temp1ViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class Temp1Profile : AutoMapper.Profile
    {
        public Temp1Profile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
