using MainDto = ApiSunSale.Application.DTO.TiposuporteDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TiposuporteViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TiposuporteProfile : AutoMapper.Profile
    {
        public TiposuporteProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
