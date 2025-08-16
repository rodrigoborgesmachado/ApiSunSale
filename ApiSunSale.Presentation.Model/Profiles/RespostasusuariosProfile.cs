using MainDto = ApiSunSale.Application.DTO.RespostasusuariosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.RespostasusuariosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RespostasusuariosProfile : AutoMapper.Profile
    {
        public RespostasusuariosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
