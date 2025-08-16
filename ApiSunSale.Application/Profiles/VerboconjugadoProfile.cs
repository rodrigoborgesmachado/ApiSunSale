using Main = ApiSunSale.Domain.Entities.Verboconjugado;
using MainDto = ApiSunSale.Application.DTO.VerboconjugadoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class VerboconjugadoProfile : AutoMapper.Profile
    {
        public VerboconjugadoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
