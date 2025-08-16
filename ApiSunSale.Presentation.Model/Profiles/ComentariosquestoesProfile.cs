using MainDto = ApiSunSale.Application.DTO.ComentariosquestoesDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ComentariosquestoesViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ComentariosquestoesProfile : AutoMapper.Profile
    {
        public ComentariosquestoesProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
