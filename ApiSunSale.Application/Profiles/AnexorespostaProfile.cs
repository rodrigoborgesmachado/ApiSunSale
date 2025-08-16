using Main = ApiSunSale.Domain.Entities.Anexoresposta;
using MainDto = ApiSunSale.Application.DTO.AnexorespostaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class AnexorespostaProfile : AutoMapper.Profile
    {
        public AnexorespostaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
