using Main = ApiSunSale.Domain.Entities.Prova;
using MainDto = ApiSunSale.Application.DTO.ProvaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ProvaProfile : AutoMapper.Profile
    {
        public ProvaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
