using Main = ApiSunSale.Domain.Entities.Tabela;
using MainDto = ApiSunSale.Application.DTO.TabelaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TabelaProfile : AutoMapper.Profile
    {
        public TabelaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
