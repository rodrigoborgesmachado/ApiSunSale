using MainDto = ApiSunSale.Application.DTO.ModulosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ModulosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ModulosProfile : AutoMapper.Profile
    {
        public ModulosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
