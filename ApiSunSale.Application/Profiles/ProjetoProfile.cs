using Main = ApiSunSale.Domain.Entities.Projeto;
using MainDto = ApiSunSale.Application.DTO.ProjetoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ProjetoProfile : AutoMapper.Profile
    {
        public ProjetoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
