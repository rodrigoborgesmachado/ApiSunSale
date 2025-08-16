using Main = ApiSunSale.Domain.Entities.Receitas;
using MainDto = ApiSunSale.Application.DTO.ReceitasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ReceitasProfile : AutoMapper.Profile
    {
        public ReceitasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
