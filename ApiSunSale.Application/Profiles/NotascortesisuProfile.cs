using Main = ApiSunSale.Domain.Entities.Notascortesisu;
using MainDto = ApiSunSale.Application.DTO.NotascortesisuDTO;

namespace ApiSunSale.Application.Profiles
{
    public class NotascortesisuProfile : AutoMapper.Profile
    {
        public NotascortesisuProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
