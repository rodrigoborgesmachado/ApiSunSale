using Main = ApiSunSale.Domain.Entities.Simulados;
using MainDto = ApiSunSale.Application.DTO.SimuladosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class SimuladosProfile : AutoMapper.Profile
    {
        public SimuladosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
