using Main = ApiSunSale.Domain.Entities.Versao;
using MainDto = ApiSunSale.Application.DTO.VersaoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class VersaoProfile : AutoMapper.Profile
    {
        public VersaoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
