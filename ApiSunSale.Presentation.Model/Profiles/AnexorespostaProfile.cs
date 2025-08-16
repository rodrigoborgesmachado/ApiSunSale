using MainDto = ApiSunSale.Application.DTO.AnexorespostaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.AnexorespostaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AnexorespostaProfile : AutoMapper.Profile
    {
        public AnexorespostaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
