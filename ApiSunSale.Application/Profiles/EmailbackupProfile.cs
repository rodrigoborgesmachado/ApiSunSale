using Main = ApiSunSale.Domain.Entities.Emailbackup;
using MainDto = ApiSunSale.Application.DTO.EmailbackupDTO;

namespace ApiSunSale.Application.Profiles
{
    public class EmailbackupProfile : AutoMapper.Profile
    {
        public EmailbackupProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
