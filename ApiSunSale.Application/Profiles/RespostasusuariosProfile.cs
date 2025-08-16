using Main = ApiSunSale.Domain.Entities.Respostasusuarios;
using MainDto = ApiSunSale.Application.DTO.RespostasusuariosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class RespostasusuariosProfile : AutoMapper.Profile
    {
        public RespostasusuariosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
