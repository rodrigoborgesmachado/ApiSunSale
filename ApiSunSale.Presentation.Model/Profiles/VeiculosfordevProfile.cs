using MainDto = ApiSunSale.Application.DTO.VeiculosfordevDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.VeiculosfordevViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class VeiculosfordevProfile : AutoMapper.Profile
    {
        public VeiculosfordevProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
