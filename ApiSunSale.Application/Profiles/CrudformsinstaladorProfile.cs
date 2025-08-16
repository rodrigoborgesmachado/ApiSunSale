using Main = ApiSunSale.Domain.Entities.Crudformsinstalador;
using MainDto = ApiSunSale.Application.DTO.CrudformsinstaladorDTO;

namespace ApiSunSale.Application.Profiles
{
    public class CrudformsinstaladorProfile : AutoMapper.Profile
    {
        public CrudformsinstaladorProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
