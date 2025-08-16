using MainDto = ApiSunSale.Application.DTO.BiomasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.BiomasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class BiomasProfile : AutoMapper.Profile
    {
        public BiomasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
