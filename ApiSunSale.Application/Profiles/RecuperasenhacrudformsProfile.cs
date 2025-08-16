using Main = ApiSunSale.Domain.Entities.Recuperasenhacrudforms;
using MainDto = ApiSunSale.Application.DTO.RecuperasenhacrudformsDTO;

namespace ApiSunSale.Application.Profiles
{
    public class RecuperasenhacrudformsProfile : AutoMapper.Profile
    {
        public RecuperasenhacrudformsProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
