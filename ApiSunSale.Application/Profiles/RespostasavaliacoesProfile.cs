using Main = ApiSunSale.Domain.Entities.Respostasavaliacoes;
using MainDto = ApiSunSale.Application.DTO.RespostasavaliacoesDTO;

namespace ApiSunSale.Application.Profiles
{
    public class RespostasavaliacoesProfile : AutoMapper.Profile
    {
        public RespostasavaliacoesProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
