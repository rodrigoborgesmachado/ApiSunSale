using Main = ApiSunSale.Domain.Entities.Parametros;
using MainDto = ApiSunSale.Application.DTO.ParametrosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ParametrosProfile : AutoMapper.Profile
    {
        public ParametrosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
