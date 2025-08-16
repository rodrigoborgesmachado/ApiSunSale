using Main = ApiSunSale.Domain.Entities.Cartaocreditodevtools;
using MainDto = ApiSunSale.Application.DTO.CartaocreditodevtoolsDTO;

namespace ApiSunSale.Application.Profiles
{
    public class CartaocreditodevtoolsProfile : AutoMapper.Profile
    {
        public CartaocreditodevtoolsProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
