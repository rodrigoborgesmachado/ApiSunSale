using Main = ApiSunSale.Domain.Entities.Usuarioscrudforms;
using MainDto = ApiSunSale.Application.DTO.UsuarioscrudformsDTO;

namespace ApiSunSale.Application.Profiles
{
    public class UsuarioscrudformsProfile : AutoMapper.Profile
    {
        public UsuarioscrudformsProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
