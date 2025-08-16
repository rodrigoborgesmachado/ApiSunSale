using Main = ApiSunSale.Domain.Entities.Tabelasmodulos;
using MainDto = ApiSunSale.Application.DTO.TabelasmodulosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TabelasmodulosProfile : AutoMapper.Profile
    {
        public TabelasmodulosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
