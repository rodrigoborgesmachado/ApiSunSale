using Main = ApiSunSale.Domain.Entities.Savedresultswpp;
using MainDto = ApiSunSale.Application.DTO.SavedresultswppDTO;

namespace ApiSunSale.Application.Profiles
{
    public class SavedresultswppProfile : AutoMapper.Profile
    {
        public SavedresultswppProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
