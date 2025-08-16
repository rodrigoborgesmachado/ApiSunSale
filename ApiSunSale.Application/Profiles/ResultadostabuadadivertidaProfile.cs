using Main = ApiSunSale.Domain.Entities.Resultadostabuadadivertida;
using MainDto = ApiSunSale.Application.DTO.ResultadostabuadadivertidaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ResultadostabuadadivertidaProfile : AutoMapper.Profile
    {
        public ResultadostabuadadivertidaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
