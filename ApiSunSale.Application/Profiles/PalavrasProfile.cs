using Main = ApiSunSale.Domain.Entities.Palavras;
using MainDto = ApiSunSale.Application.DTO.PalavrasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class PalavrasProfile : AutoMapper.Profile
    {
        public PalavrasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
