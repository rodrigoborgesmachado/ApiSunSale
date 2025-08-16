using Main = ApiSunSale.Domain.Entities.Avaliacao;
using MainDto = ApiSunSale.Application.DTO.AvaliacaoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class AvaliacaoProfile : AutoMapper.Profile
    {
        public AvaliacaoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
