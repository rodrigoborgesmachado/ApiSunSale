using Main = ApiSunSale.Domain.Entities.Usuarioconcursando;
using MainDto = ApiSunSale.Application.DTO.UsuarioconcursandoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class UsuarioconcursandoProfile : AutoMapper.Profile
    {
        public UsuarioconcursandoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
