using Main = ApiSunSale.Domain.Entities.Email;
using MainDto = ApiSunSale.Application.DTO.EmailDTO;

namespace ApiSunSale.Application.Profiles
{
    public class EmailProfile : AutoMapper.Profile
    {
        public EmailProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
