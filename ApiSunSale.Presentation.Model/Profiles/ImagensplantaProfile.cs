using MainDto = ApiSunSale.Application.DTO.ImagensplantaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ImagensplantaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ImagensplantaProfile : AutoMapper.Profile
    {
        public ImagensplantaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
