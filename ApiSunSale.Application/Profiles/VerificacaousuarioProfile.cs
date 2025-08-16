using Main = ApiSunSale.Domain.Entities.Verificacaousuario;
using MainDto = ApiSunSale.Application.DTO.VerificacaousuarioDTO;

namespace ApiSunSale.Application.Profiles
{
    public class VerificacaousuarioProfile : AutoMapper.Profile
    {
        public VerificacaousuarioProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
