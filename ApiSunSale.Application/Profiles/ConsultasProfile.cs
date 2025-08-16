using Main = ApiSunSale.Domain.Entities.Consultas;
using MainDto = ApiSunSale.Application.DTO.ConsultasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ConsultasProfile : AutoMapper.Profile
    {
        public ConsultasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
