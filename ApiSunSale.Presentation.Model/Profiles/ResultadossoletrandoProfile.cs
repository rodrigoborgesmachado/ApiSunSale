using MainDto = ApiSunSale.Application.DTO.ResultadossoletrandoDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ResultadossoletrandoViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ResultadossoletrandoProfile : AutoMapper.Profile
    {
        public ResultadossoletrandoProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
