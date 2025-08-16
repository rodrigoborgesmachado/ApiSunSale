using Main = ApiSunSale.Domain.Entities.Campos;
using MainDto = ApiSunSale.Application.DTO.CamposDTO;

namespace ApiSunSale.Application.Profiles
{
    public class CamposProfile : AutoMapper.Profile
    {
        public CamposProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
