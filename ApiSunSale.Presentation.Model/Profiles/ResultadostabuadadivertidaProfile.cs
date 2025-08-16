using MainDto = ApiSunSale.Application.DTO.ResultadostabuadadivertidaDTO;
using MainViewModel = ApiSunSale.Presentation.Model.ViewModels.ResultadostabuadadivertidaViewModel;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ResultadostabuadadivertidaProfile : AutoMapper.Profile
    {
        public ResultadostabuadadivertidaProfile()
        {
            CreateMap<MainDto, MainViewModel>().PreserveReferences();
            CreateMap<MainViewModel, MainDto>().PreserveReferences();
        }
    }
}
