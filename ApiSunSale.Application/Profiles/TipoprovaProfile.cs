using Main = ApiSunSale.Domain.Entities.Tipoprova;
using MainDto = ApiSunSale.Application.DTO.TipoprovaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TipoprovaProfile : AutoMapper.Profile
    {
        public TipoprovaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
