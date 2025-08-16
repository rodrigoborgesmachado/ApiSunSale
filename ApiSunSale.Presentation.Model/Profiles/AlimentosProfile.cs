using MainDto = ApiSunSale.Application.DTO.AlimentosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.AlimentosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AlimentosProfile : AutoMapper.Profile
    {
        public AlimentosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
