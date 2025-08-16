using MainDto = ApiSunSale.Application.DTO.ConsultasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ConsultasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ConsultasProfile : AutoMapper.Profile
    {
        public ConsultasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
