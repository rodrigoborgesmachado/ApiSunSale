using MainDto = ApiSunSale.Application.DTO.ContabancofordevDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ContabancofordevViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ContabancofordevProfile : AutoMapper.Profile
    {
        public ContabancofordevProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
