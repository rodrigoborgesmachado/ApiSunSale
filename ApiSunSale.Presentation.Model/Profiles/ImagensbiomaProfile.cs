using MainDto = ApiSunSale.Application.DTO.ImagensbiomaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ImagensbiomaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ImagensbiomaProfile : AutoMapper.Profile
    {
        public ImagensbiomaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
