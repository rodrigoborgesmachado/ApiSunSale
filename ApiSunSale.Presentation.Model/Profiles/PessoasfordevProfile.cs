using MainDto = ApiSunSale.Application.DTO.PessoasfordevDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.PessoasfordevViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class PessoasfordevProfile : AutoMapper.Profile
    {
        public PessoasfordevProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
