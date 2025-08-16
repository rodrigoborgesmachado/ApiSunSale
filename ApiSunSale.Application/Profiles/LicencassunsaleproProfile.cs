using Main = ApiSunSale.Domain.Entities.Licencassunsalepro;
using MainDto = ApiSunSale.Application.DTO.LicencassunsaleproDTO;

namespace ApiSunSale.Application.Profiles
{
    public class LicencassunsaleproProfile : AutoMapper.Profile
    {
        public LicencassunsaleproProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
