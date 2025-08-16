using MainDto = ApiSunSale.Application.DTO.RespostasquestoesDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.RespostasquestoesViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RespostasquestoesProfile : AutoMapper.Profile
    {
        public RespostasquestoesProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
