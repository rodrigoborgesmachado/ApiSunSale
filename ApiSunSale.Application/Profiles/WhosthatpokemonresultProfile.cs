using Main = ApiSunSale.Domain.Entities.Whosthatpokemonresult;
using MainDto = ApiSunSale.Application.DTO.WhosthatpokemonresultDTO;

namespace ApiSunSale.Application.Profiles
{
    public class WhosthatpokemonresultProfile : AutoMapper.Profile
    {
        public WhosthatpokemonresultProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
