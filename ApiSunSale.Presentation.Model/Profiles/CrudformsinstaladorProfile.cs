using MainDto = ApiSunSale.Application.DTO.CrudformsinstaladorDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.CrudformsinstaladorViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class CrudformsinstaladorProfile : AutoMapper.Profile
    {
        public CrudformsinstaladorProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
