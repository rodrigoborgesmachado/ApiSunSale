using MainDto = ApiSunSale.Application.DTO.MetasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.MetasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class MetasProfile : AutoMapper.Profile
    {
        public MetasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
