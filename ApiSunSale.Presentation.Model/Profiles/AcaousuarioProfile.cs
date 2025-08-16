using MainDto = ApiSunSale.Application.DTO.AcaousuarioDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.AcaousuarioViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AcaousuarioProfile : AutoMapper.Profile
    {
        public AcaousuarioProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
