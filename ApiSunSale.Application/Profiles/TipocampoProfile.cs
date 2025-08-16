using Main = ApiSunSale.Domain.Entities.Tipocampo;
using MainDto = ApiSunSale.Application.DTO.TipocampoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TipocampoProfile : AutoMapper.Profile
    {
        public TipocampoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
