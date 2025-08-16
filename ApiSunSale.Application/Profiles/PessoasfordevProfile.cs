using Main = ApiSunSale.Domain.Entities.Pessoasfordev;
using MainDto = ApiSunSale.Application.DTO.PessoasfordevDTO;

namespace ApiSunSale.Application.Profiles
{
    public class PessoasfordevProfile : AutoMapper.Profile
    {
        public PessoasfordevProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
