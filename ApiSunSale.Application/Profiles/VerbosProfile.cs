using Main = ApiSunSale.Domain.Entities.Verbos;
using MainDto = ApiSunSale.Application.DTO.VerbosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class VerbosProfile : AutoMapper.Profile
    {
        public VerbosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
