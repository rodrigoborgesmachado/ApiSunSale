using MainDto = ApiSunSale.Application.DTO.SavedresultswppDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.SavedresultswppViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class SavedresultswppProfile : AutoMapper.Profile
    {
        public SavedresultswppProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
