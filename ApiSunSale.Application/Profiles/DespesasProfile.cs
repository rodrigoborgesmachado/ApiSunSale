using Main = ApiSunSale.Domain.Entities.Despesas;
using MainDto = ApiSunSale.Application.DTO.DespesasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class DespesasProfile : AutoMapper.Profile
    {
        public DespesasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
