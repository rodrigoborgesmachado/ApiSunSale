using MainDto = ApiSunSale.Application.DTO.TipoprovaassociadoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TipoprovaassociadoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TipoprovaassociadoProfile : AutoMapper.Profile
    {
        public TipoprovaassociadoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
