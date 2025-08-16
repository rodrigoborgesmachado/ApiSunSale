using Main = ApiSunSale.Domain.Entities.Modulos;
using MainDto = ApiSunSale.Application.DTO.ModulosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ModulosProfile : AutoMapper.Profile
    {
        public ModulosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
