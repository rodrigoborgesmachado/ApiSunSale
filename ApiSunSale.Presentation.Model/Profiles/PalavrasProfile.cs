using MainDto = ApiSunSale.Application.DTO.PalavrasDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.PalavrasViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class PalavrasProfile : AutoMapper.Profile
    {
        public PalavrasProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
