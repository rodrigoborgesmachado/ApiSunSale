using MainDto = ApiSunSale.Application.DTO.VerbosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.VerbosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class VerbosProfile : AutoMapper.Profile
    {
        public VerbosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
