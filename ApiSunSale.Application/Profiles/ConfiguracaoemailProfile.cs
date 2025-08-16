using Main = ApiSunSale.Domain.Entities.Configuracaoemail;
using MainDto = ApiSunSale.Application.DTO.ConfiguracaoemailDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ConfiguracaoemailProfile : AutoMapper.Profile
    {
        public ConfiguracaoemailProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
