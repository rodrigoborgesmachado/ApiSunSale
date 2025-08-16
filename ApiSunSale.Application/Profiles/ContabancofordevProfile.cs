using Main = ApiSunSale.Domain.Entities.Contabancofordev;
using MainDto = ApiSunSale.Application.DTO.ContabancofordevDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ContabancofordevProfile : AutoMapper.Profile
    {
        public ContabancofordevProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
