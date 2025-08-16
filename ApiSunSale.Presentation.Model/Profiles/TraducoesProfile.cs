using MainDto = ApiSunSale.Application.DTO.TraducoesDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.TraducoesViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class TraducoesProfile : AutoMapper.Profile
    {
        public TraducoesProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
