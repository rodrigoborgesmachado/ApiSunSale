using Main = ApiSunSale.Domain.Entities.Respostasquestoes;
using MainDto = ApiSunSale.Application.DTO.RespostasquestoesDTO;

namespace ApiSunSale.Application.Profiles
{
    public class RespostasquestoesProfile : AutoMapper.Profile
    {
        public RespostasquestoesProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
