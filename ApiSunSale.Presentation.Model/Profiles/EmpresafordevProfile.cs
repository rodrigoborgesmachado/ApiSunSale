using MainDto = ApiSunSale.Application.DTO.EmpresafordevDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.EmpresafordevViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class EmpresafordevProfile : AutoMapper.Profile
    {
        public EmpresafordevProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
