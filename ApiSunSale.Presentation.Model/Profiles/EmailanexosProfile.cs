using MainDto = ApiSunSale.Application.DTO.EmailanexosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.EmailanexosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class EmailanexosProfile : AutoMapper.Profile
    {
        public EmailanexosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
