using Main = ApiSunSale.Domain.Entities.Anexosquestoes;
using MainDto = ApiSunSale.Application.DTO.AnexosquestoesDTO;

namespace ApiSunSale.Application.Profiles
{
    public class AnexosquestoesProfile : AutoMapper.Profile
    {
        public AnexosquestoesProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
