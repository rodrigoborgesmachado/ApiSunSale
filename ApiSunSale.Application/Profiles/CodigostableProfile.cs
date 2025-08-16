using Main = ApiSunSale.Domain.Entities.Codigostable;
using MainDto = ApiSunSale.Application.DTO.CodigostableDTO;

namespace ApiSunSale.Application.Profiles
{
    public class CodigostableProfile : AutoMapper.Profile
    {
        public CodigostableProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
