using MainDto = ApiSunSale.Application.DTO.TabelasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TabelasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TabelasProfile : AutoMapper.Profile
    {
        public TabelasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
