using MainDto = ApiSunSale.Application.DTO.EmailDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.EmailViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class EmailProfile : AutoMapper.Profile
    {
        public EmailProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
