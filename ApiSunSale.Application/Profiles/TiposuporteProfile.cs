using Main = ApiSunSale.Domain.Entities.Tiposuporte;
using MainDto = ApiSunSale.Application.DTO.TiposuporteDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TiposuporteProfile : AutoMapper.Profile
    {
        public TiposuporteProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
