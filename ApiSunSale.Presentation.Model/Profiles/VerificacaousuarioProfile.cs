using MainDto = ApiSunSale.Application.DTO.VerificacaousuarioDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.VerificacaousuarioViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class VerificacaousuarioProfile : AutoMapper.Profile
    {
        public VerificacaousuarioProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
