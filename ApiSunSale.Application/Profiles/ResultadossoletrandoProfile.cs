using Main = ApiSunSale.Domain.Entities.Resultadossoletrando;
using MainDto = ApiSunSale.Application.DTO.ResultadossoletrandoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ResultadossoletrandoProfile : AutoMapper.Profile
    {
        public ResultadossoletrandoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
