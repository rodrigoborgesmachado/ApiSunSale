using Main = ApiSunSale.Domain.Entities.Acaousuario;
using MainDto = ApiSunSale.Application.DTO.AcaousuarioDTO;

namespace ApiSunSale.Application.Profiles
{
    public class AcaousuarioProfile : AutoMapper.Profile
    {
        public AcaousuarioProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
