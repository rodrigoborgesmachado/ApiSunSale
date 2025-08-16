using MainDto = ApiSunSale.Application.DTO.TabelasmodulosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TabelasmodulosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TabelasmodulosProfile : AutoMapper.Profile
    {
        public TabelasmodulosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
