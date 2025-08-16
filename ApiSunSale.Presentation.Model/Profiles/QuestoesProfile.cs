using MainDto = ApiSunSale.Application.DTO.QuestoesDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.QuestoesViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class QuestoesProfile : AutoMapper.Profile
    {
        public QuestoesProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
