using Main = ApiSunSale.Domain.Entities.Relacao;
using MainDto = ApiSunSale.Application.DTO.RelacaoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class RelacaoProfile : AutoMapper.Profile
    {
        public RelacaoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
