using Main = ApiSunSale.Domain.Entities.Recuperasenhaconcursando;
using MainDto = ApiSunSale.Application.DTO.RecuperasenhaconcursandoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class RecuperasenhaconcursandoProfile : AutoMapper.Profile
    {
        public RecuperasenhaconcursandoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
