using MainDto = ApiSunSale.Application.DTO.ProjetoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ProjetoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ProjetoProfile : AutoMapper.Profile
    {
        public ProjetoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
