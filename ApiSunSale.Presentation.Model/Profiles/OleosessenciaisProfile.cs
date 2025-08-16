using MainDto = ApiSunSale.Application.DTO.OleosessenciaisDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.OleosessenciaisViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class OleosessenciaisProfile : AutoMapper.Profile
    {
        public OleosessenciaisProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
