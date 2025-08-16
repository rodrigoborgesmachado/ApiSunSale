using Main = ApiSunSale.Domain.Entities.Tipoprovaassociado;
using MainDto = ApiSunSale.Application.DTO.TipoprovaassociadoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TipoprovaassociadoProfile : AutoMapper.Profile
    {
        public TipoprovaassociadoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
