using Main = ApiSunSale.Domain.Entities.Postagem;
using MainDto = ApiSunSale.Application.DTO.PostagemDTO;

namespace ApiSunSale.Application.Profiles
{
    public class PostagemProfile : AutoMapper.Profile
    {
        public PostagemProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
