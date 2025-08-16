using Main = ApiSunSale.Domain.Entities.Biomas;
using MainDto = ApiSunSale.Application.DTO.BiomasDTO;

namespace ApiSunSale.Application.Profiles
{
    public class BiomasProfile : AutoMapper.Profile
    {
        public BiomasProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
