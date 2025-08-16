using MainDto = ApiSunSale.Application.DTO.PostagemDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.PostagemViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class PostagemProfile : AutoMapper.Profile
    {
        public PostagemProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
