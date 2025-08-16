using MainDto = ApiSunSale.Application.DTO.CamposDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.CamposViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class CamposProfile : AutoMapper.Profile
    {
        public CamposProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
