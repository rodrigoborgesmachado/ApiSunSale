using MainDto = ApiSunSale.Application.DTO.ClientesDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ClientesViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ClientesProfile : AutoMapper.Profile
    {
        public ClientesProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
