using MainDto = ApiSunSale.Application.DTO.AnexosquestoesDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.AnexosquestoesViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AnexosquestoesProfile : AutoMapper.Profile
    {
        public AnexosquestoesProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
