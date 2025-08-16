using Main = ApiSunSale.Domain.Entities.Tabelas;
using MainDto = ApiSunSale.Application.DTO.TabelasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TabelasProfile : AutoMapper.Profile
    {
        public TabelasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
