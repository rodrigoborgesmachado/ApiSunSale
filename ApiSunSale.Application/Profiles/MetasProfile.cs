using Main = ApiSunSale.Domain.Entities.Metas;
using MainDto = ApiSunSale.Application.DTO.MetasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class MetasProfile : AutoMapper.Profile
    {
        public MetasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
