using Main = ApiSunSale.Domain.Entities.Comentariosquestoes;
using MainDto = ApiSunSale.Application.DTO.ComentariosquestoesDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ComentariosquestoesProfile : AutoMapper.Profile
    {
        public ComentariosquestoesProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
