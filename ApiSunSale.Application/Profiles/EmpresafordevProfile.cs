using Main = ApiSunSale.Domain.Entities.Empresafordev;
using MainDto = ApiSunSale.Application.DTO.EmpresafordevDTO;

namespace ApiSunSale.Application.Profiles
{
    public class EmpresafordevProfile : AutoMapper.Profile
    {
        public EmpresafordevProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
