using Main = ApiSunSale.Domain.Entities.Questoesavaliacao;
using MainDto = ApiSunSale.Application.DTO.QuestoesavaliacaoDTO;

namespace ApiSunSale.Application.Profiles
{
    public class QuestoesavaliacaoProfile : AutoMapper.Profile
    {
        public QuestoesavaliacaoProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
