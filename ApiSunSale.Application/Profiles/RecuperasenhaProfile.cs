using Main = ApiSunSale.Domain.Entities.Recuperasenha;
using MainDto = ApiSunSale.Application.DTO.RecuperasenhaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class RecuperasenhaProfile : AutoMapper.Profile
    {
        public RecuperasenhaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
