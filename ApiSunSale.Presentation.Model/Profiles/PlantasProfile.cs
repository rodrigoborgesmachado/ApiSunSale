using MainDto = ApiSunSale.Application.DTO.PlantasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.PlantasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class PlantasProfile : AutoMapper.Profile
    {
        public PlantasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
