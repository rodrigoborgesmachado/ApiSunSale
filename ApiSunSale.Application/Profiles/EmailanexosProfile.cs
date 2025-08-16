using Main = ApiSunSale.Domain.Entities.Emailanexos;
using MainDto = ApiSunSale.Application.DTO.EmailanexosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class EmailanexosProfile : AutoMapper.Profile
    {
        public EmailanexosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
