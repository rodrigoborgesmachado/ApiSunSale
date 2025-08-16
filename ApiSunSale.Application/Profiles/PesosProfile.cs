using Main = ApiSunSale.Domain.Entities.Pesos;
using MainDto = ApiSunSale.Application.DTO.PesosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class PesosProfile : AutoMapper.Profile
    {
        public PesosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
