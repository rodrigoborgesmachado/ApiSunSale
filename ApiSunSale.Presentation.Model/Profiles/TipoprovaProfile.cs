using MainDto = ApiSunSale.Application.DTO.TipoprovaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TipoprovaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TipoprovaProfile : AutoMapper.Profile
    {
        public TipoprovaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
