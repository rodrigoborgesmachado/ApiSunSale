using Main = ApiSunSale.Domain.Entities.Temp1;
using MainDto = ApiSunSale.Application.DTO.Temp1DTO;

namespace ApiSunSale.Application.Profiles
{
    public class Temp1Profile : AutoMapper.Profile
    {
        public Temp1Profile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
