using Main = ApiSunSale.Domain.Entities.Oleosessenciais;
using MainDto = ApiSunSale.Application.DTO.OleosessenciaisDTO;

namespace ApiSunSale.Application.Profiles
{
    public class OleosessenciaisProfile : AutoMapper.Profile
    {
        public OleosessenciaisProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
