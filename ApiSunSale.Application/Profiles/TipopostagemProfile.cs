using Main = ApiSunSale.Domain.Entities.Tipopostagem;
using MainDto = ApiSunSale.Application.DTO.TipopostagemDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TipopostagemProfile : AutoMapper.Profile
    {
        public TipopostagemProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
