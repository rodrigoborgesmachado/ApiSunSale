using MainDto = ApiSunSale.Application.DTO.TipocampoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TipocampoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TipocampoProfile : AutoMapper.Profile
    {
        public TipocampoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
