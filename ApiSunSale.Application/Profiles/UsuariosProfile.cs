using Main = ApiSunSale.Domain.Entities.Usuarios;
using MainDto = ApiSunSale.Application.DTO.UsuariosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class UsuariosProfile : AutoMapper.Profile
    {
        public UsuariosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
