using MainDto = ApiSunSale.Application.DTO.QuestoesavaliacaoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.QuestoesavaliacaoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class QuestoesavaliacaoProfile : AutoMapper.Profile
    {
        public QuestoesavaliacaoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
