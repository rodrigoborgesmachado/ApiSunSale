using MainDto = ApiSunSale.Application.DTO.EmailbackupDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.EmailbackupViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class EmailbackupProfile : AutoMapper.Profile
    {
        public EmailbackupProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
