using MainDto = ApiSunSale.Application.DTO.ProvaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ProvaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ProvaProfile : AutoMapper.Profile
    {
        public ProvaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
