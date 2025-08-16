using Main = ApiSunSale.Domain.Entities.Logg;
using MainDto = ApiSunSale.Application.DTO.LoggDTO;

namespace ApiSunSale.Application.Profiles
{
    public class LoggProfile : AutoMapper.Profile
    {
        public LoggProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
