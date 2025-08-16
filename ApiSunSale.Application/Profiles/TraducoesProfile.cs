using Main = ApiSunSale.Domain.Entities.Traducoes;
using MainDto = ApiSunSale.Application.DTO.TraducoesDTO;

namespace ApiSunSale.Application.Profiles
{
    public class TraducoesProfile : AutoMapper.Profile
    {
        public TraducoesProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
