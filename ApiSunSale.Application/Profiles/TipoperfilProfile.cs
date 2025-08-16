using Main = ApiSunSale.Domain.Entities.Tipoperfil;
using MainDto = ApiSunSale.Application.DTO.TipoperfilDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TipoperfilProfile : AutoMapper.Profile
    {
        public TipoperfilProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
