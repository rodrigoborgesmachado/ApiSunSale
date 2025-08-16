using MainDto = ApiSunSale.Application.DTO.ReceitasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ReceitasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ReceitasProfile : AutoMapper.Profile
    {
        public ReceitasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
