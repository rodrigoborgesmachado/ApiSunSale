using MainDto = ApiSunSale.Application.DTO.DespesasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.DespesasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class DespesasProfile : AutoMapper.Profile
    {
        public DespesasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
