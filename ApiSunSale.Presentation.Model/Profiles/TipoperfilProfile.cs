using MainDto = ApiSunSale.Application.DTO.TipoperfilDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TipoperfilViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TipoperfilProfile : AutoMapper.Profile
    {
        public TipoperfilProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
