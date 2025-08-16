using Main = ApiSunSale.Domain.Entities.Teste;
using MainDto = ApiSunSale.Application.DTO.TesteDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TesteProfile : AutoMapper.Profile
    {
        public TesteProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
