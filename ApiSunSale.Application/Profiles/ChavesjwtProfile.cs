using Main = ApiSunSale.Domain.Entities.Chavesjwt;
using MainDto = ApiSunSale.Application.DTO.ChavesjwtDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ChavesjwtProfile : AutoMapper.Profile
    {
        public ChavesjwtProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
