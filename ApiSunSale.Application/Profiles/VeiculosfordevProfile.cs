using Main = ApiSunSale.Domain.Entities.Veiculosfordev;
using MainDto = ApiSunSale.Application.DTO.VeiculosfordevDTO;

namespace ApiSunSale.Application.Profiles
{
    public class VeiculosfordevProfile : AutoMapper.Profile
    {
        public VeiculosfordevProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
