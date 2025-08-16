using MainDto = ApiSunSale.Application.DTO.CategoriaalimentosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.CategoriaalimentosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class CategoriaalimentosProfile : AutoMapper.Profile
    {
        public CategoriaalimentosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
