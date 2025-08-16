using Main = ApiSunSale.Domain.Entities.Alimentos;
using MainDto = ApiSunSale.Application.DTO.AlimentosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class AlimentosProfile : AutoMapper.Profile
    {
        public AlimentosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
