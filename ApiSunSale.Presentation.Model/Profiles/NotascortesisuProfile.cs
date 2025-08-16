using MainDto = ApiSunSale.Application.DTO.NotascortesisuDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.NotascortesisuViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class NotascortesisuProfile : AutoMapper.Profile
    {
        public NotascortesisuProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
