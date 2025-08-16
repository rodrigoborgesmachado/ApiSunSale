using Main = ApiSunSale.Domain.Entities.Plantas;
using MainDto = ApiSunSale.Application.DTO.PlantasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class PlantasProfile : AutoMapper.Profile
    {
        public PlantasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
