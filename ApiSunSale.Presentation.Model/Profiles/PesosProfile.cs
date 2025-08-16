using MainDto = ApiSunSale.Application.DTO.PesosDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.PesosViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class PesosProfile : AutoMapper.Profile
    {
        public PesosProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
