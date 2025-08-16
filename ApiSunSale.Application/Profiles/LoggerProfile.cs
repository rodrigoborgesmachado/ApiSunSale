using Main = ApiSunSale.Domain.Entities.Logger;
using MainDto = ApiSunSale.Application.DTO.LoggerDTO;

namespace ApiSunSale.Application.Profiles
{
    public class LoggerProfile : AutoMapper.Profile
    {
        public LoggerProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
